using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace P224Juan.Models
{
    public class Slider:BaseEntity
    {
        [StringLength(255)]
        public string SubTitle { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile SliderImageFile { get; set; }

    }
}
