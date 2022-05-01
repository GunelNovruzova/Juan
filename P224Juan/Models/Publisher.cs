using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace P224Juan.Models
{
    public class Publisher:BaseEntity
    {
        [StringLength(255)]
        public string PublisherName { get; set; }
        [StringLength(1000)]
        public string PublisherImage { get; set; }
        [StringLength(255)]
        public string PublisherPosition { get; set; }
        [NotMapped]
        public IFormFile PublisherImageFile { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
