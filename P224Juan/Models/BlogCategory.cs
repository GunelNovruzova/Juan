using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class BlogCategory:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<BlogtoCategory> BlogtoCategories { get; set; }
       
    }
}
