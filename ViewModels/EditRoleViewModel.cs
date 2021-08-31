using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class EditRoleViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string Name { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? RoleDescription { get; set; }
    }
}
