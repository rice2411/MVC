using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public int id { get; set; }
        public string avatarPath { get; set; }
      
    }
}
