using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class FilmCreateViewModel
    {
        public string filmId { get; set; }
        [Required]
        [Display(Name ="Film Name")]
        public string filmName { get; set; }

        [Display(Name = "Description ")]
        public string filmDescription { get; set; }
       
   
        [Display(Name ="Poster")]
        public IFormFile filmPoster { get; set; }
        [Display(Name= "Time")]
        public int timeOfFilm { get; set; }
    }
}
