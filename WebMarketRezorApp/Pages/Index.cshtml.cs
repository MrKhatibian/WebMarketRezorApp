using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarketRezorApp.Data;
using WebMarketRezorApp.Model;

namespace WebMarketRezorApp.Pages
{
    public class IndexModel : PageModel
    {        
        //Make DbConntext object
        private readonly WebAppRazorDbContext _db;
        //Make Constractor DbContext For Read Database
        public IndexModel(WebAppRazorDbContext db)
        {
            db = _db;
        }
        //Make property for send Dbconntext(Products talbe info) info to index page
        public IEnumerable<Products> Products { get; set; }
        public void OnGet()
        {

        }
    }
}
