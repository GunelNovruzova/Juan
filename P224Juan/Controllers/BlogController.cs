using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.ViewModels.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index(int page =1)
        {
            BlogVM blogVM = new BlogVM
            {

                Categories = await _context.Categories.Include(c => c.Products).Where(c => !c.IsDeleted).ToListAsync(),
                Tags =await _context.Tags.Where(c=>!c.IsDeleted).ToListAsync(),
                Blogs = await _context.Blogs.Where(b => !b.IsDeleted).Skip((page - 1) * 6).Take(6).ToListAsync()
            };

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)_context.Blogs.Where(b => !b.IsDeleted).Count() / 6);
            return View(blogVM);
        }
    }
}
