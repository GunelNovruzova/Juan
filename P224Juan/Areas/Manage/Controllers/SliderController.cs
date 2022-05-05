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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public async Task<IActionResult> Index(bool? status, int page = 1)
        {
            return View(await _context.Sliders.ToListAsync());
        }
        public async Task<IActionResult> Detail()
        {
            return View(await _context.Sliders.FirstOrDefaultAsync());
        }
        public async Task<IActionResult> Update()
        {
            return View(await _context.Sliders.FirstOrDefaultAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Slider slider)
        {
            //    return View(await _context.Settings.FirstOrDefaultAsync());
            Slider dbSlider = await _context.Sliders.FirstOrDefaultAsync();

            //setting.Logo = dbSetting.Logo;

            if (!ModelState.IsValid)
            {
                return View(dbSlider);
            }

            if (slider.SliderImageFile != null)
            {
                if (!slider.SliderImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("LogoImage", "Secilen Seklin Novu Uygun");
                    return View(dbSlider);
                }

                if (!slider.SliderImageFile.CheckFileSize(30))
                {
                    ModelState.AddModelError("LogoImage", "Secilen Seklin Olcusu Maksimum 30 Kb Ola Biler");
                    return View(dbSlider);
                }


                Helper.Helper.DeleteFile(_env, dbSlider.Image, "assets", "img", "slider");

                dbSlider.Image = slider.SliderImageFile.CreateFile(_env, "assets", "img", "slider");
            }

            dbSlider.Title = slider.Title;
            dbSlider.SubTitle = slider.SubTitle;
            dbSlider.Description = slider.Description;
           
            dbSlider.UpdatedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }


    }
}
