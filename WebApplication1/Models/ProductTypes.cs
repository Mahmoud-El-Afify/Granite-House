﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductTypes
    {
        public int id { get; set; }
        
        

        [Required]
        public int Name { get; set; }



    }
}
