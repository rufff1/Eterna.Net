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
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.Include(t => t.Position).ToList();
            return View(teams);
        }
    }
}
