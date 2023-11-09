using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMarketRezorApp.Data;
using WebMarketRezorApp.Model;

namespace WebMarketRezorApp.Pages
{
    public class ProfileModel : PageModel
    {
        // Make DbContext object
        private readonly WebAppRazorDbContext db;
        // Make Constactor for Read DB info
        public ProfileModel(WebAppRazorDbContext _db)
        {
            _db = db;
        }
        //Make Propert Element for Resive Element Talbe info
        public IEnumerable<Elements> Elements { get; set; }
        // Send Db info to Front
        public void OnGet()
        {
            
        }
    }
}
