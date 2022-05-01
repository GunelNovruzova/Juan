using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P224Juan.Models
{
    public class ProductColor:BaseEntity
    {
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ColorId { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
