using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebMarket.DataAccess.Data;
using WebMarket.Models;

namespace WebMarketRezorApp.Pages
{
    public class UserMangmentModel : PageModel
    {
        // Make DbContext object
        private readonly WebAppRazorDbContext _db;
        // Make Constactor for Read DB info
        public UserMangmentModel(WebAppRazorDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        //Make Propert Element for Resive Element Talbe info
        public IEnumerable<Elements> IE_Element { get; set; }       
        // Send Db info to Front
        public void OnGet()
        {
            IE_Element = _db.Elements;
        }        
    }
}
