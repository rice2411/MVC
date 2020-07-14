using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Seat
    {

        public string seatId { get; set; }
        [ForeignKey("Rooms")]
        public string roomId { get; set; }
        public StatusSeat seatStatus { get; set; } = StatusSeat.empty;
    }
}
