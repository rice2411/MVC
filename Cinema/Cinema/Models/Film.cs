using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Film
    {
        public string filmId { get; set; }
        public string filmName { get; set; }
        public string filmPoster { get; set; }
        public int timeOfFilm { get; set; }
        public string filmDescription { get; set; }
      
      
    }
}
