using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.Extensions;
using P224Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(bool? status, int page = 1)
        {
            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs

                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);

            return View(blogs.Skip((page - 1) * 5).Take(5));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("ImageFile", "Secilen Seklin Novu Uygun Deyil");
                    return View();
                }
                if (!blog.ImageFile.CheckFileSize(100))
                {
                    ModelState.AddModelError("ImageFile", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
                    return View();
                }
                blog.Image = blog.ImageFile.CreateFile(_env, "assets", "img", "blog");
            }
            blog.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);

            if (blog == null) return NotFound();

            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog, bool? status, int page = 1)
        {
            if (!ModelState.IsValid) return View(blog);

            if (id == null) return BadRequest();

            if (id != blog.Id) return BadRequest();

            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);
            blog.Image = dbBlog.Image;

            if (dbBlog == null) return NotFound();


            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("LogoImage", "Secilen Seklin Novu Uygun Deyil");
                    return View(dbBlog);
                }
                if (!blog.ImageFile.CheckFileSize(100))
                {
                    ModelState.AddModelError("LogoImage", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
                    return View(dbBlog);
                }
                Helper.Helper.DeleteFile(_env, dbBlog.Image, "assets", "img", "blog");
                dbBlog.Image = blog.ImageFile.CreateFile(_env, "assets", "img", "blog");
            }

            dbBlog.Title = blog.Title;
            dbBlog.Description = blog.Description;
            dbBlog.PublisherName = blog.PublisherName;
            dbBlog.UpdatedAt = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { status = status, page = page });
        }
        public async Task<IActionResult> Delete(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);

            if (dbBlog == null) return NotFound();

            dbBlog.IsDeleted = true;
            dbBlog.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs

                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);



            return PartialView("_BlogIndexPartial", blogs.Skip((page - 1) * 5).Take(5));
        }
        public async Task<IActionResult> Restore(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);

            if (dbBlog == null) return NotFound();

            dbBlog.IsDeleted = false;

            await _context.SaveChangesAsync();

            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs

                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);



            return PartialView("_BlogIndexPartial", blogs.Skip((page - 1) * 5).Take(5));
        }

    }
}
