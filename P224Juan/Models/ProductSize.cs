using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class ProductSize:BaseEntity
    {
        public int SizeId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Size Size { get; set; }
        public Product Product { get; set; }
    }
}
