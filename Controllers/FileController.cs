using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using IBBPortal.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Controllers
{
    [Authorize]
    [GenerateAntiforgeryTokenCookie]
    public class FileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly long _fileSizeLimit;
        private readonly ILogger<FileController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string[] _permittedExtensions = { ".txt", ".png", ".jpg", ".pdf", ".jpeg", ".webp" };
        private readonly string _targetFilePath;

        // Get the default form options so that we can use them to set the default 
        // limits for request body data.
        private static readonly FormOptions _defaultFormOptions = new FormOptions();

        public FileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            ILogger<FileController> logger, IConfiguration config)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;

            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");

            // To save physical files to a path provided by configuration:
            _targetFilePath = config.GetValue<string>("StoredFilesPath");

            // To save physical files to the temporary files folder, use:
            //_targetFilePath = Path.GetTempPath();
        }

        public IActionResult Index(int id)
        {
            //Handle Errors for Files
            var SuccessTitle = HttpContext.Request.Query["successTitle"].FirstOrDefault();
            var SuccessMessage = HttpContext.Request.Query["successMessage"].FirstOrDefault();
            var ErrorTitle = HttpContext.Request.Query["errorTitle"].FirstOrDefault();
            var ErrorMessage = HttpContext.Request.Query["errorMessage"].FirstOrDefault();

            if (!String.IsNullOrEmpty(SuccessTitle)) { ViewBag.SuccessTitle = SuccessTitle; }
            if (!String.IsNullOrEmpty(SuccessMessage)) { ViewBag.SuccessMessage = SuccessMessage; }
            if (!String.IsNullOrEmpty(ErrorTitle)) { ViewBag.ErrorTitle = ErrorTitle; }
            if (!String.IsNullOrEmpty(ErrorMessage)) { ViewBag.ErrorMessage = ErrorMessage; }

            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            ViewBag.ProjectID = id;
            return View();
        }

        [HttpPost]
        public JsonResult JSONData(int projectID)
        {
            try
            {

                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault().ToUpper();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var data = _context.File
                    .Select(c => new
                    {
                        c.FileID,
                        c.ProjectID,
                        c.FileCategoryID,
                        c.FileCategory.FileCategoryTitle,
                        FileName = c.FileName,
                        FileType = c.FileType != null ? c.FileType : "",
                        FilePath = c.FilePath != null ? c.FilePath : "",
                        FileURL = c.FileURL != null ? c.FileURL : "",
                        FileUploadType = c.FileUploadType,
                        c.DeletionDate
                    })
                    .Where(c => c.ProjectID == projectID && c.DeletionDate == null);

                //Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    var sortProp = sortColumn + " " + sortColumnDirection;
                    data = data.OrderBy(sortProp);
                }

                //Search Functionality = Programmer will always know how many columns will be shown to the user.
                //So we will use that to check every column if they have a search value.
                //If control checks out, search. If not loop goes on until the end.
                string columnName, searchValue;

                for (int i = 0; i < 6; i++)
                {
                    columnName = Request.Form[$"columns[{i}][data]"].FirstOrDefault();
                    searchValue = Request.Form[$"columns[{i}][search][value]"].FirstOrDefault();

                    if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchValue))
                    {
                        data = data.WhereContains(columnName, searchValue);
                    }
                }

                //total number of rows count   
                recordsTotal = data.Count();
                //Paging   
                var passData = data.Skip(skip).Take(pageSize).ToList();

                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: File/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var file = await _context.File
                .Include(p => p.ProjectBidding)
                .Include(p => p.FileCategory)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.FileID == id);

            if (file == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", file);
        }

        // GET: File/Create/ProjectID
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: File/Create/ProjectID
        [HttpPost]
        // Two filters are customly created.
        // We need to disable model binding of ASP.NET Core MVC
        // in order to upload files with streamming method.
        [DisableModelBindingHelper]
        // Because we disabled Model Binding, we need to validate Antiforgery Token
        // ourselves now. To generate it, we generated a cookie filter at the top of the 
        // controller. See Helpers folder for more information.
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            // Check to see if the content coming is send in the enctype="multipart/form-data" format
            // In file transactions, streaming should be used id the files are uploaded frequently.
            // This method is based on ASP.NET docs -> Advanced Guide.
            // Check the link for more information: https://docs.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-5.0#upload-large-files-with-streaming
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("File",
                    $"Bir hata oluştu! Lütfen daha sonra tekrar deneyin.");
                // Log error
                _logger.LogError("There was an error processing the request!");
                return BadRequest(ModelState);
            }

            var boundary = MultipartRequestHelper.GetBoundary(
                MediaTypeHeaderValue.Parse(Request.ContentType),
                _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            //Dictionary to save non-file fields (text, select, textare etc.)
            // Don't change this part as it will corrupt the model binding!
            Dictionary<string, dynamic> formValues = new Dictionary<string, dynamic>();

            while (section != null)
            {
                var hasContentDispositionHeader =
                    ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {

                    if (!MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        var key = HeaderUtilities.RemoveQuotes(contentDisposition.Name).Value;

                        using (var streamReader = new StreamReader(section.Body,
                             encoding: Encoding.UTF8,
                             detectEncodingFromByteOrderMarks: true,
                             bufferSize: 1024,
                             leaveOpen: true))
                        {
                            var value = await streamReader.ReadToEndAsync();
                            if (string.Equals(value, "undefined", StringComparison.OrdinalIgnoreCase))
                            {
                                value = string.Empty;
                            }

                            formValues.Add(key, value);

                        }
                    }
                    else
                    {
                        // Don't trust the file name sent by the client. To display
                        // the file name, HTML-encode the value.
                        var fileName = "";

                        if (formValues.ContainsKey("FileName"))
                        {
                            fileName = WebUtility.HtmlEncode(formValues["FileName"]);
                        }

                        //File Name coming from the Stream. Change it with user input value.
                        // Dont forget to get File Extension from the stream!
                        var trustedFileNameForDisplay = WebUtility.HtmlEncode(contentDisposition.FileName.Value);

                        var trustedFileExtension = Path.GetExtension(trustedFileNameForDisplay).ToLower();
                        var trustedFileNameForFileStorage = !String.IsNullOrEmpty(fileName) ? fileName + trustedFileExtension : trustedFileNameForDisplay;

                        //Add file extension to formValues Dictionary to save to the database.
                        formValues.Add("FileType", trustedFileExtension);

                        // **WARNING!**
                        // In the following example, the file is saved without
                        // scanning the file's contents. In most production
                        // scenarios, an anti-virus/anti-malware scanner API
                        // is used on the file before making the file available
                        // for download or for use by other systems. 
                        // For more information, see the topic that accompanies 
                        // this sample.

                        var streamedFileContent = await FileHelper.ProcessStreamedFile(
                            section, contentDisposition, ModelState,
                            _permittedExtensions, _fileSizeLimit);

                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        using (var targetStream = System.IO.File.Create(
                            Path.Combine(_targetFilePath, trustedFileNameForFileStorage)))
                        {
                            await targetStream.WriteAsync(streamedFileContent);

                            formValues.Add("FilePath", Path.Combine(_targetFilePath, trustedFileNameForFileStorage));

                            _logger.LogInformation(
                                "Uploaded file '{TrustedFileNameForDisplay}' saved to " +
                                "'{TargetFilePath}' as {TrustedFileNameForFileStorage}",
                                trustedFileNameForDisplay, _targetFilePath,
                                trustedFileNameForFileStorage);
                        }
                    }
                }

                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                section = await reader.ReadNextSectionAsync();
            }

            if (!formValues.ContainsKey("FilePath"))
            {
                formValues.Add("FilePath", "");
            }

            if (!formValues.ContainsKey("FileType"))
            {
                formValues.Add("FileType", "");
            }

            //Create File model to save to the database
            Models.File file = new Models.File()
            {
                FileUploadType = Convert.ToInt32(formValues["FileUploadType"]),
                ProjectID = Convert.ToInt32(formValues["ProjectID"]),
                FileCategoryID = Convert.ToInt32(formValues["FileCategoryID"]),
                ProjectBiddingID = !String.IsNullOrEmpty(formValues["ProjectBiddingID"]) ? Convert.ToInt32(formValues["ProjectBiddingID"]) : null,
                FileTags = !String.IsNullOrEmpty(formValues["FileTags"]) ? formValues["FileTags"] : null,
                FileName = !String.IsNullOrEmpty(formValues["FileName"]) ? formValues["FileName"] : null,
                FileType = !String.IsNullOrEmpty(formValues["FileType"]) ? formValues["FileType"] : null,
                FilePath = !String.IsNullOrEmpty(formValues["FilePath"]) ? formValues["FilePath"] : null,
                FileURL = !String.IsNullOrEmpty(formValues["FileURL"]) ? formValues["FileURL"] : null,
                UserID = _userManager.GetUserId(HttpContext.User),
                CreationDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.AddAsync(file);
                    await _context.SaveChangesAsync();

                    JsonResult response = new JsonResult(new { });

                    response.StatusCode = 200;
                    response.Value = new
                    {
                        SuccessTitle = "BAŞARILI",
                        SuccessMessage = "Kayıt başarıyla oluşturuldu.",
                    };

                    return response;
                }

                catch (Exception)
                {
                    JsonResult response = new JsonResult(new { Test = "Test" });

                    response.StatusCode = 400;
                    response.Value = new
                    {
                        SuccessTitle = "HATA",
                        SuccessMessage = "Kayıt oluşturulamadı.",
                    };

                    return response;
                }
            }

            return View("_CreateModal");
        }

        // GET: File/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var file = await _context.File
                .Include(p => p.ProjectBidding)
                .Include(p => p.FileCategory)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.FileID == id);

            if (file == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", file);
        }

        // POST: File/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileToUpdate = _context.File.Find(id);

            fileToUpdate.UpdateDate = DateTime.Now;

            if (await TryUpdateModelAsync<Models.File>(fileToUpdate, "",
                x => x.FileCategoryID,
                x => x.ProjectBiddingID, x => x.FileTags,
                x => x.FileName, x => x.FileURL,
                x => x.UpdateDate))
            {
                try
                {

                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileExists(fileToUpdate.FileID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["ErrorTitle"] = "HATA";
                        TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    }
                }
                return RedirectToAction(nameof(Index), new { id = fileToUpdate.ProjectID });
            }
            return View(fileToUpdate);
        }

        // GET: ProjectPhase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var file = await _context.File.FindAsync(id);

            if (file == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", file);
        }

        // POST: ProjectPhase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var file = await _context.File.FindAsync(id);

            try
            {
                file.DeletionDate = DateTime.Now;
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"Kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index), new { id = file.ProjectID });
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = file.ProjectID });
            }
        }

        private bool FileExists(int id)
        {
            return _context.File.Any(e => e.FileID == id);
        }
    }
}
