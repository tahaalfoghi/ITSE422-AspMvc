using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    
    public class ProfileController : Controller
    {
        private readonly AppDbContext _context;


        public ProfileController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var profiles = await _context.Set<Profile>().ToListAsync();
            return View(profiles);
        }
    }
}