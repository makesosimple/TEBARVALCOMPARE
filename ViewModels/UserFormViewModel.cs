using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TEBARVALCOMPARE.ViewModels
{
    public class UserFormViewModel
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
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir e-posta adresi girin.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(100, ErrorMessage = "Şifre en az {2} karakter ve en fazla {1} karater uzunluğunda olabilir.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string RoleID { get; set; }
    }
}
