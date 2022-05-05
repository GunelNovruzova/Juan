using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace P224Juan.Models
{
    public class Color:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<ProductColorSize> ProductColorSizes { get; set; }
    }
} 
