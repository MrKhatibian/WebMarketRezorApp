using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebMarket.DataAccess.Data;
using WebMarket.Models;

namespace WebMarketRezorApp.Pages
{
    public class FormElementsModel : PageModel
    {
        // Creat obj for resive data from front
        private readonly WebAppRazorDbContext _db;
        // make constactor for access to Database
        public FormElementsModel(WebAppRazorDbContext db)
        {
            _db = db;
        }
        //Make Element prop for resive info from FormElements
        public Elements Element { get; set; }
        // Make async post Method for Sent Data to db
        public async Task<IActionResult> OnPost(Elements Element)
        {
            //Add Validation for Server
            if (ModelState.IsValid)
            {
                await _db.Elements.AddAsync(Element);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
