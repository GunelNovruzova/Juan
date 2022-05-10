using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.Models;
using P224Juan.ViewModels.BlogDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace P224Juan.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly AppDbContext _context;
        public BlogDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            BlogDetailVM blogDetailVM = new BlogDetailVM
            {
                Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync(),
                Tags = await _context.Tags.Where(c => !c.IsDeleted).ToListAsync(),
                Blogs = await _context.Blogs.Where(c=>!c.IsDeleted).ToListAsync()
            };
          
            return View(blogDetailVM);
        }
    }
}
