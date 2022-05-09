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
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DetailModal(int? id)
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();
            if (id == null) return BadRequest();

            Product product = await _context.Products
                .Include(p => p.ProductImages)
                .Include(p=>p.ProductColorSizes).ThenInclude(p=>p.Color)
                .Include(p=>p.ProductColorSizes).ThenInclude(p=>p.Size)

                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            if (product == null) return NotFound();

            return PartialView("_ProductDetailPartial", product);
        }
        public async Task<IActionResult> AddBasket(int? id, int count = 1, string colorid="",string sizeid="")
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
           
            if (product == null) return NotFound();

            //List<Product> products = null;
            string cookiebasket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;

          
            if (cookiebasket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookiebasket);
                if (basketVMs.Any(b => b.ProductId == id &&(b.Color==colorid && b.Size==sizeid)))
                {
                    basketVMs.Find(b => b.ProductId == id).Count += count;
                }
                else
                {
                    basketVMs.Add(new BasketVM
                    {
                        ProductId = (int)id,
                        Count = count,
                        Color=colorid,
                        Size=sizeid
                       
                    });
                }

            }
            else
            {
                basketVMs = new List<BasketVM>();
                basketVMs.Add(new BasketVM()
                {
                    ProductId = product.Id,
                    Count = count,
                    Color = colorid,
                    Size = sizeid

                });
             }
            cookiebasket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", cookiebasket);
            foreach (BasketVM basketVM in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
                basketVM.Image = dbProduct.MainImage;
                basketVM.Price = dbProduct.DiscountPrice > 0 ? dbProduct.DiscountPrice : dbProduct.Price;
                basketVM.Name = dbProduct.Name;
              

            }


           
            return PartialView("_BasketPartial", basketVMs);
        }

        //public async Task<IActionResult> GetBasket()
        //{
        //    string cookieBasket = HttpContext.Request.Cookies["basket"];

        //    List<BasketVM> basketVMs = null;

        //    if (cookieBasket != null)
        //    {
        //        basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookieBasket);
        //    }
        //    else
        //    {
        //        basketVMs = new List<BasketVM>();
        //    }

        //    foreach (BasketVM basketVM in basketVMs)
        //    {
        //        Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
        //        basketVM.Image = dbProduct.MainImage;
        //        basketVM.Price = dbProduct.DiscountPrice > 0 ? dbProduct.DiscountPrice : dbProduct.Price;
        //        basketVM.Name = dbProduct.Name;
               
        //    }

        //    return PartialView("_BasketPartial", basketVMs);
        //}


    
    }
}
