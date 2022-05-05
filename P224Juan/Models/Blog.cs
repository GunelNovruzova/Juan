using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace P224Juan.Models
{
    public class Blog:BaseEntity
    {
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        public string PublisherName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
       
      
    }
}
