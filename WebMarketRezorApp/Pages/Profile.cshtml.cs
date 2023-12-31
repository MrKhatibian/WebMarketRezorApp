using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.DataAccess.Data;
using WebMarket.Models;

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
        public IEnumerable<Elements> IE_Element { get; set; }
        public Elements Element { get; set; }
        // Send Db info to Front
        public void OnGet(int? id)
        {
            if (id!= null)            
                Element = _db.Elements.Find(id);
            else
                Element = _db.Elements.First();            
        }
        // Make async post Method for Sent Data to db
        public async Task<IActionResult> OnPost(Elements Element)
        {
            //Add Validation for Server
            if (ModelState.IsValid)
            {
                _db.Elements.Update(Element);
                await _db.SaveChangesAsync();
                return RedirectToPage("/UserMangment");
            }
            return RedirectToPage("/Index");
        }
    }
}
