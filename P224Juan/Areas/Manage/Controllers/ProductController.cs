﻿using Microsoft.AspNetCore.Authorization;
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
               .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
               .Include(p => p.ProductColorSizes).ThenInclude(pc => pc.Color)
               .Include(p=>p.ProductColorSizes).ThenInclude(pc=> pc.Size)
               .Include(t => t.Category)
               
               
                .Where(t => status != null ? t.IsDeleted == status : !t.IsDeleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)products.Count() / 5);

            return View(products.Skip((page - 1) * 5).Take(5));
        }

        public async Task<IActionResult> Detail(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Product product = await _context.Products
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .Include(p => p.ProductColorSizes).ThenInclude(pc=>pc.Color)
                 .Include(p => p.ProductColorSizes).ThenInclude(pc => pc.Size)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }
        public async Task<IActionResult> Create(bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(t => !t.IsDeleted).ToListAsync();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(t => !t.IsDeleted).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (product.ProductImagesFile.Count() > 6)
            {
                ModelState.AddModelError("ProductImagesFile", $"max image count is 6");
                return View();
            }

            if (!await _context.Categories.AnyAsync(b => b.Id == product.CategoryId && !b.IsDeleted))
            {
                ModelState.AddModelError("CategoryId", "Duzgun Category Secin ");
                return View();
            }

            if (product.TagIds.Count > 0)
            {
                List<ProductTag> productTags = new List<ProductTag>();

                foreach (int item in product.TagIds)
                {
                    if (!await _context.Tags.AnyAsync(t => t.Id != item && !t.IsDeleted))
                    {
                        ModelState.AddModelError("TagIds", $"Secilen Id {item} - li Tag Yanlisdir");
                        return View();
                    }

                    ProductTag productTag = new ProductTag
                    {
                        TagId = item
                    };

                    productTags.Add(productTag);
                }

                product.ProductTags = productTags;
            }
            List<ProductColorSize> productColorSizes = new List<ProductColorSize>();

            if (product.SizeIds.Count > 0)
            {
                //List<ProductColorSize> productColorSizes = new List<ProductColorSize>();
                foreach (int item in product.SizeIds)
                {
                    if (!await _context.Sizes.AnyAsync(t => t.Id != item && !t.IsDeleted))
                    {
                        ModelState.AddModelError("SizeIds", $"Secilen Id {item} - li Size Yanlisdir");
                        return View();
                    }

                    ProductColorSize productcolorsize = new ProductColorSize
                    {
                        SizeId = item
                    };

                    productColorSizes.Add(productcolorsize);
                }

                 //product.ProductColorSizes = productColorSizes;
            }

            if(product.ColorIds.Count > 0)
            {
                //List<ProductColorSize> productColorSizes = new List<ProductColorSize>();

                foreach (int item in product.ColorIds)
                {
                    if (!await _context.Colors.AnyAsync(t => t.Id != item && !t.IsDeleted))
                    {
                        ModelState.AddModelError("ColorIds", $"Secilen Id {item} - li Color Yanlisdir");
                        return View();
                    }

                    ProductColorSize productcolorsize = new ProductColorSize
                    {
                        ColorId = item
                    };

                    productColorSizes.Add(productcolorsize);
                }

                //product.ProductColorSizes = productColorSizes;
            }

            product.ProductColorSizes = productColorSizes;

            if (product.MainImageFile != null)
            {
                if (!product.MainImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("MainImageFile", "Secilen Seklin Novu Uygun");
                    return View();
                }

                if (!product.MainImageFile.CheckFileSize(300))
                {
                    ModelState.AddModelError("MainImageFile", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
                    return View();
                }

                product.MainImage = product.MainImageFile.CreateFile(_env, "assets", "img", "product");
            }
            else
            {
                ModelState.AddModelError("MainImageFile", "Main Sekil Mutleq Secilmelidir");
                return View();
            }

            if (product.ProductImagesFile.Count() > 0)
            {
                List<ProductImage> productImages = new List<ProductImage>();

                foreach (IFormFile file in product.ProductImagesFile)
                {
                    if (!file.CheckFileContentType("image/jpeg"))
                    {
                        ModelState.AddModelError("ProductImagesFile", "Secilen Seklin Novu Uygun");
                        return View();
                    }

                    if (!file.CheckFileSize(300))
                    {
                        ModelState.AddModelError("ProductImagesFile", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
                        return View();
                    }

                    ProductImage productImage = new ProductImage
                    {
                        Image = file.CreateFile(_env, "assets", "img", "product"),
                        CreatedAt = DateTime.UtcNow.AddHours(4)
                    };

                    productImages.Add(productImage);
                }

                product.ProductImages = productImages;
            }
            else
            {
                ModelState.AddModelError("ProductImagesFile", "Product Images File Sekil Mutleq Secilmelidir");
                return View();
            }



            product.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("index", new { status, page });
        }



        
    }
}
