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
    public class FormElementsModel : PageModel
    {
        // Creat obj for resive data from front
        private readonly WebAppRazorDbContext _db;
        // make constactor for access to Database
        public FormElementsModel(WebAppRazorDbContext db)
        {

        }
        //Make Element prop for resive info from FormElements
        public Elements Element { get; set; }
        
        public void OnPost()
        {
        }
    }
}
