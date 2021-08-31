using IBBPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class UserEditViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string RoleID { get; set; }

        public ApplicationRole Role { get; set; }
    }
}
