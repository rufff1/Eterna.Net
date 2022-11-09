using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            PortfolioVm portfolioVm = new PortfolioVm
            {
                Portfolio =_context.Portfolios.FirstOrDefault(),
                Clients =_context.Clients.ToList()
            };
           
            return View(portfolioVm);
        }
    }
}
