using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarketRezorApp.Model;

namespace WebMarketRezorApp.Data
{
    public class WebAppRazorDbContext : DbContext
    {
        public WebAppRazorDbContext(DbContextOptions<WebAppRazorDbContext> Option): base(Option)
        {
        }
        //Make DbSet Products
        public DbSet<Products> Products { get; set; }
        //Make DbSet Elements
        public DbSet<Elements> Elements { get; set; }       
    }
}
