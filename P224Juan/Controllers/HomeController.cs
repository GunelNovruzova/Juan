using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using P224Juan.DAL;
using P224Juan.Models;
using P224Juan.ViewModels.Basket;
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
        public IActionResult Index()
        {
            List<Product> products = _context.Products.Where(p => !p.IsDeleted).ToList();
            return View(products);
        }
        public async Task<IActionResult> AddBasket(int? id, int count=1)
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();

            //List<Product> products = null;
            List<BasketVM> basketVMs = null;

            string cookiebasket = HttpContext.Request.Cookies["basket"];
            if (cookiebasket!=null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookiebasket);
                if (basketVMs.Any(b => b.ProductId == id))
                {
                    basketVMs.Find(b => b.ProductId == id).Count += count;
                }
                else
                {


                    basketVMs.Add(new BasketVM
                    {
                        ProductId = (int)id,
                        Count = count
                    });
                }

            }
            
            else
            {
                basketVMs = new List<BasketVM>();
               
            }
            basketVMs.Add(new BasketVM()
            {
                ProductId = product.Id,
                Count = count
            }); 
            
 
            HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketVMs));
            return Ok();
        }
    }
}
