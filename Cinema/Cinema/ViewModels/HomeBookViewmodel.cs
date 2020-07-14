using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class HomeBookViewmodel : Seat
    {
        public string filmName { get; set; }
        public string filmPoster { get; set; }
        public int timeOfFilm { get; set; }
        public bool isSlected {get; set;}
    }
}
