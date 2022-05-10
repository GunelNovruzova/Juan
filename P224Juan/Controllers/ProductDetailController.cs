 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _context;
        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products
                .Include(p=>p.ProductColorSizes).ThenInclude(p=>p.Color)
                .Include(p => p.ProductColorSizes).ThenInclude(p => p.Size)
                .Include(p=>p.ProductImages)
                .FirstOrDefaultAsync(product=>product.Id==id);
            if (product == null) return NotFound();

            return View(product);
        }
    }
}
