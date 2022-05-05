using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class Review:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int Star { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
