using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class BlogSingleController : Controller
    {
        private readonly AppDbContext _context;
        public BlogSingleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<BlogSingle> blogSingles = _context.BlogSingles.ToList();

            return View(blogSingles);
        }
    }
}
