using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.Models;
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
        private readonly UserManager<AppUser> _userManager;

        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        public async Task<IActionResult> Detail(int? id)
        {

            Review review = await _context.Reviews.FirstOrDefaultAsync(r => r.BlogId == id);
            ViewBag.UserId = review.AppUserId;
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Tags = await _context.Tags.ToListAsync();
            ViewBag.Blogs = await _context.Blogs.ToListAsync();
            if (id == null) return BadRequest();
            Blog blog = await _context.Blogs
                .Include(b=>b.Reviews)
                 .FirstOrDefaultAsync(u=>u.Id==id);
            if (blog == null) return NotFound();

            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(int? bid,Review review)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }
                AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
                review.Name = appUser.UserName;
                review.Email = appUser.Email;
                review.BlogId = (int)bid;
                review.AppUserId = appUser.Id;
                review.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            int id = (int)bid;
            return RedirectToAction("detail",new { id });
        }
        
    }
}
