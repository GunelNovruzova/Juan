using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class BlogtoCategory
    {

        public int Id { get; set; }
        public Nullable<int> BlogId { get; set; }
        public Blog Blog { get; set; }
        public Nullable<int> BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }
    }
}
