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
   
    public class BlogSingle : Controller
    {
        private readonly AppDbContext _context;
        public BlogSingle(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogVm blogVm = new BlogVm
            {
                Blog=_context.Blogs.FirstOrDefault(),
                Categories = _context.Categories.ToList(),
                RecentPosts=_context.RecentPosts.ToList(),
                Tags=_context.Tags.ToList()
            };
       

            return View(blogVm);
        }
    }
}
