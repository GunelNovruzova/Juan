using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using P224Juan.DAL;
using P224Juan.Models;
using P224Juan.ViewModels.Basket;
using P224Juan.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
               Products = await _context.Products
               .Include(p=>p.ProductColorSizes).ThenInclude(p=>p.Color)
                .Include(p => p.ProductColorSizes).ThenInclude(p => p.Size)
               .Where(p => !p.IsDeleted).ToListAsync(),
                Sliders = await _context.Sliders.Where(p => !p.IsDeleted).ToListAsync(),
                Blogs= await _context.Blogs.Where(p=>!p.IsDeleted).ToListAsync(),
                Brands = await _context.Brands.Where(p => !p.IsDeleted).ToListAsync()

            };
            
            return View(homeVM);

        }
    
    }
}
