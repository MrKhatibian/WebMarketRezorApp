using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebMarket.DataAccess.Data;
using WebMarket.Models;

namespace WebMarketRezorApp.Pages
{
    public class IndexModel : PageModel
    {        
        //Make DbConntext object
        private readonly WebAppRazorDbContext _db;
        //Make Constractor DbContext For Read Database
        public IndexModel(WebAppRazorDbContext db)
        {
            _db = db;
        }
        //Make property for send Dbconntext(Products talbe info) info to index page
        public IEnumerable<Products> Products { get; set; }
        public void OnGet()
        {
            Products = _db.Products;
        }
    }
}
