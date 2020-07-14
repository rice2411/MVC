using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Room
    {
    
        public string roomId { get; set; }
       
        public StatusRoom statusRoom { get; set; }

       
        public int Seatavailable { get; set; }



    }
}
