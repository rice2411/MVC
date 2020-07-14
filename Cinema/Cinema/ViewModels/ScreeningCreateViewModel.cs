using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class ScreeningCreateViewModel
    {

        public string screeningID { get; set; }
       
        [Display(Name ="Film")]
        public string filmId { get; set; }
      
        [Display(Name ="Room")]
        public string roomId { get; set; }
       
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
    }
}
