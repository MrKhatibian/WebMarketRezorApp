﻿using Microsoft.EntityFrameworkCore;
using WebMarket.Models;

namespace WebMarket.DataAccess.Data
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
