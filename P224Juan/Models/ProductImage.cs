﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Image { get; set; }
    }
}
