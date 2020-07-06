using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
     
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FullName { get; set; }
        public int Age => DOB.HasValue ? DateTime.Now.Year - DOB.Value.Year : 0;
        [Required(ErrorMessage ="Invalid DOB")]
        public DateTime? DOB { get; set; }
        [Required]
        [Display(Name="Office Mail")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Department have to choose")]
        public DPM? Department { get; set; }
        public string Avatar { get; set; }
       
    }
}
