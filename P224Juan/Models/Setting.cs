using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace P224Juan.Models
{
    public class Setting:BaseEntity
    {
        public string Logo { get; set; }
        public string Greeting { get; set; }
        [StringLength(255), Required]
        public string Email { get; set; }
        [StringLength(255), Required]
        public string Phone { get; set; }
        [StringLength(255), Required]
        public string Address { get; set; }
        public string ContactUsTitle { get; set; }
        public string ContactUsDescription { get; set; }
        public string WorkHours { get; set; }
        [NotMapped]

        public IFormFile LogoImage { get; set; }

    }
}
