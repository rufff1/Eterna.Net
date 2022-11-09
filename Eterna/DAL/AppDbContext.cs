using Eterna.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.DAL
{
    public class AppDbContext :DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSingle> BlogSingles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<PrService> PrServices { get; set; }
        public DbSet<RecentPost> RecentPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Home> Homes { get; set; }

    }
}
