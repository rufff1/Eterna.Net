using Eterna.DAL;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVm aboutVm = new AboutVm
            {
                Abouts = _context.Abouts.FirstOrDefault(),
                Clients = _context.Clients.ToList(),
                Testimonials =_context.Testimonials.ToList()
            };

      

            return View(aboutVm);
        }
    }
}
