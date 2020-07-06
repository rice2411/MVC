using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class UserCreateViewModel 
    {
        [Required]
        public string User { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage ="PassWord not maatch")]
        public string ConfirmPassword { get; set; }
        [Display(Name ="Role")]
        public string RoleId { get; set; }               
    }
}
