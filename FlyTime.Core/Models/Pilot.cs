﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTime.Core.Models
{
    public class Pilot
    {
        [Key]
        public int Id { get; set; }

        public string Matricule { get; set; } = "";
        
        public string Email { get; set; } = "";
        
        public string Password { get; set; } = "";
        
        public List<Vol>? Vols { get; set; }
    }
}
