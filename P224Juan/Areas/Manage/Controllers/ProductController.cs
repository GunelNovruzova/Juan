using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(bool? status, int page = 1)
        {
            ViewBag.Status = status;

            IEnumerable<Product> products = await _context.Products

                .Include(t => t.Category)
                .Include(t => t.ProductSizes)
                .Include(t => t.ProductColors)
                .Where(t => status != null ? t.IsDeleted == status : !t.IsDeleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)products.Count() / 5);

            return View(products.Skip((page - 1) * 5).Take(5));
        }
        public async Task<IActionResult> Create(bool? status, int page = 1)
        {

            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();


            return View();
        }
        
        //public async Task<IActionResult> Create(Product product, bool? status, int page = 1)
        //{

        //    ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();


        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if (product.ProductImagesFile.Count() > 6)
        //    {
        //        ModelState.AddModelError("ProductImagesFile", $"maksimum yukleyebileceyin say 6");
        //        return View();
        //    }

        //    if (!await _context.Categories.AnyAsync(b => b.Id == product.CategoryId && !b.IsDeleted))
        //    {
        //        ModelState.AddModelError("CategoryId", "Duzgun Category Secin ");
        //        return View();
        //    }



        //    if (product.MainImageFile != null)
        //    {
        //        if (!product.MainImageFile.CheckFileContentType("image/jpeg"))
        //        {
        //            ModelState.AddModelError("MainImageFile", "Secilen Seklin Novu Uygun");
        //            return View();
        //        }

        //        if (!product.MainImageFile.CheckFileSize(300))
        //        {
        //            ModelState.AddModelError("MainImageFile", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
        //            return View();
        //        }

        //        product.MainImage = product.MainImageFile.CreateFile(_env, "assets", "images", "product");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("MainImageFile", "Main Sekil Mutleq Secilmelidir");
        //        return View();
        //    }

        //    if (product.ProductImagesFile.Count() > 0)
        //    {
        //        List<ProductSize> productSizes = new List<ProductSize>();

        //        foreach (IFormFile file in product.ProductImagesFile)
        //        {
        //            if (!file.CheckFileContentType("image/jpeg"))
        //            {
        //                ModelState.AddModelError("ProductImagesFile", "Secilen Seklin Novu Uygun");
        //                return View();
        //            }

        //            if (!file.CheckFileSize(300))
        //            {
        //                ModelState.AddModelError("ProductImagesFile", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
        //                return View();
        //            }

        //            ProductSize productSize = new ProductSize
        //            {
        //                Image = file.CreateFile(_env, "assets", "images", "product"),
        //                CreatedAt = DateTime.UtcNow.AddHours(4)
        //            };

        //            productSizes.Add(productSize);
        //        }

        //        product.ProductSizes = productSizes;
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("ProductImagesFile", "Product Images File Sekil Mutleq Secilmelidir");
        //        return View();
        //    }

        //    product.Availability = product.Count > 0 ? true : false;
        //    product.CreatedAt = DateTime.UtcNow.AddHours(4);

        //    await _context.Products.AddAsync(product);
        //    await _context.SaveChangesAsync();

        //    return RedirectToAction("index", new { status, page });
        //}
    }
}
