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
        private readonly WebAppRazorDbContext _db;
        // Make Constactor for Read DB info
        public ProfileModel(WebAppRazorDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        //Make Propert Element for Resive Element Talbe info
        public IEnumerable<Elements> Elements { get; set; }
        // Send Db info to Front
        public void OnGet()
        {
            //Elements = _db.Elements.Find(id);
            //Elements = _db.Elements;
        }

        // Make async post Method for Sent Data to db
        public async Task<IActionResult> OnPost(Elements element)
        {
            //Add Validation for Server
            if (ModelState.IsValid)
            {
                
                _db.Elements.Update(element);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Profile");
            }
            return RedirectToPage("/Index");
        }
    }
}
