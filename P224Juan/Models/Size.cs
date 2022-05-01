using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<ProductSize> ProductSizes { get; set; }
    }
}
