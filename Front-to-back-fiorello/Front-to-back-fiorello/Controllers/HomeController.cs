using Front_to_back_fiorello.Data;
using Front_to_back_fiorello.Models;
using Front_to_back_fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_fiorello.Controllers
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
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync();
            IEnumerable<Category> categories = await _context.Categories.Where(m => m.IsDeleted == false).ToListAsync();
            IEnumerable<Product> products = await _context.Products.Take(8)
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.ProductImage).ToListAsync();
            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetail = sliderDetail,
                Categories = categories,
                Products = products
            };
            return View(model);
        }

    }
}
