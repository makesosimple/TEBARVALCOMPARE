using TEBARVALCOMPARE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TEBARVALCOMPARE.ViewModels
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string RoleID { get; set; }

        public ApplicationRole Role { get; set; }
    }
}
