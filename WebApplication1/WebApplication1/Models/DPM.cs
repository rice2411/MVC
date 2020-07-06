using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum DPM
    {
        IT,
        [System.ComponentModel.DataAnnotations.Display(Name ="Q&A")]
        QA
    }
}
