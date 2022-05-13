using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Juan.DAL;
using P224Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AppUser> appUsers = _context.AppUsers.ToList();
            return View(appUsers);
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id == null) return BadRequest();
            
            AppUser appUser = await _context.AppUsers.FirstOrDefaultAsync(u => u.Id == id);
            if (appUser == null) return NotFound();
            return View(appUser);
        }
    }
}
