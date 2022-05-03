using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using P224Juan.DAL;
using P224Juan.Models;
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
        //    public async Task<IActionResult> AddBasket(int? id, int count = 1)
        //    {
        //        if (id == null) return BadRequest();

        //        Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

        //        if (product == null) return NotFound();

        //        string cookieBasket = HttpContext.Request.Cookies["basket"];

        //        List<BasketVM> basketVMs = null;

        //        if (cookieBasket != null)
        //        {
        //            basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookieBasket);

        //            if (basketVMs.Any(b => b.ProductId == id))
        //            {
        //                basketVMs.Find(b => b.ProductId == id).Count += count;
        //            }
        //            else
        //        //    {
        //        //        #region old
        //        //        //BasketVM basketVM = new BasketVM
        //        //        //{
        //        //        //    ProductId = (int)id,
        //        //        //    Count = count
        //        //        //};

        //        //        //basketVMs.Add(basketVM);
        //        //        #endregion

        //        //        basketVMs.Add(new/* BasketVM*/
        //        //        {
        //        //            ProductId = (int)id,
        //        //            Count = count
        //        //        });
        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    basketVMs = new List<BasketVM>();
        //        //    basketVMs.Add(new BasketVM
        //        //    {
        //        //        ProductId = (int)id,
        //        //        Count = count
        //        //    });
        //        //}

        //        cookieBasket = JsonConvert.SerializeObject(basketVMs);
        //        HttpContext.Response.Cookies.Append("basket", cookieBasket);

        //        //foreach (BasketVM basketVM in basketVMs)
        //        //{
        //        //    Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
        //        //    basketVM.Image = dbProduct.MainImage;
        //        //    basketVM.Price = dbProduct.DiscountPrice > 0 ? dbProduct.DiscountPrice : dbProduct.Price;
        //        //    basketVM.ExTax = dbProduct.ExTax;
        //        //    basketVM.Title = dbProduct.Title;
        //        //}

        //        return PartialView("_BasketPartial", basketVMs);
        //    }
        //}
    }
}
