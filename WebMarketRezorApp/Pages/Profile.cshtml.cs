using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMarketRezorApp.Data;

namespace WebMarketRezorApp.Pages
{
    public class ProfileModel : PageModel
    {
        // Make DbContext object
        private readonly WebAppRazorDbContext db;
        public void OnGet()
        {
        }
    }
}
