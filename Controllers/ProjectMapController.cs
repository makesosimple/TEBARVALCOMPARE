using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Controllers
{
    public class ProjectMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
