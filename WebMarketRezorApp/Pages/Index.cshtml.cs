using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarketRezorApp.Data;

namespace WebMarketRezorApp.Pages
{
    public class IndexModel : PageModel
    {        
        //Make DbConntext object
        private readonly WebAppRazorDbContext _db;

        public IndexModel()
        {

        }
        public void OnGet()
        {

        }
    }
}
