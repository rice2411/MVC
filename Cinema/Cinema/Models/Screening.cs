using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Screening
    {
        [Key]
        public string screeningID { get; set; }
        [ForeignKey("Films")]
        public string filmId { get; set; }
        [ForeignKey("Rooms")]
        public string roomId { get; set; }
        public string filmName { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
    }
}
