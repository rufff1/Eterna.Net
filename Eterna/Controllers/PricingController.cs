using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pricing> pricings = _context.Pricings
             .Include(p => p.PricingServices).ThenInclude(ps => ps.PrService).ToList();

            ViewBag.PrServicesCount= _context.PrServices.Count();
            return View(pricings);
        }
    }
}
