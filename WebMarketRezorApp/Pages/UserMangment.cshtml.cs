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
        public Elements Element { get; set; }
        // Send Db info to Front
        public void OnGet()
        {
            Element = _db.Elements.Find(1002);
            //IE_Element = _db.Elements;
        }        
    }
}
