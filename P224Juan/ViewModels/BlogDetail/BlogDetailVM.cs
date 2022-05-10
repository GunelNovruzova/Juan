using P224Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.ViewModels.BlogDetail
{
    public class BlogDetailVM
    {
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public List<P224Juan.Models.Blog> Blogs { get; set; }
    }
}
