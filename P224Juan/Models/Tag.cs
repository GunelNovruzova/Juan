﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<BlogTag> BlogTags { get; set; }
    }
} 
