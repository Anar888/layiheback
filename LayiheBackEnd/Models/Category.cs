﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayiheBackEnd.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 250)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
