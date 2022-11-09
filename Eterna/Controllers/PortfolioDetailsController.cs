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
    public class PortfolioDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<PortfolioDetail> portfolioDetails = _context.PortfolioDetails
             .Include(p => p.Portfolio).ToList();

     
            return View(portfolioDetails);
        }
    }
}
