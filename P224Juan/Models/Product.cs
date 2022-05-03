using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace P224Juan.Models
{
    public class Product:BaseEntity
    {
       [StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public int Count { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string MainImage { get; set; }
        public bool IsAvailable { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<ProductColor> ProductColors { get; set; }
        public IEnumerable<ProductSize> ProductSizes { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [NotMapped]
        public IFormFile[] ProductImagesFile { get; set; }
    }
}
 