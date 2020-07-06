﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class EditRoleViewModel
    {
        public string id { get; set; }
        [Required]
        public string roleName { get; set; }
    }
}
