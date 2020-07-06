using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeCreateViewModel
    {
        public string Name { get; set; }
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Invalid DOB")]
        public DateTime? DOB { get; set; }
        [Required]
        [Display(Name = "Office Mail")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Department have to choose")]
        public DPM? Department { get; set; }
        public IFormFile AvatarPath { get; set; }
    }
}
