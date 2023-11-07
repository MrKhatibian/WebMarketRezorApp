using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMarketRezorApp.Model;

namespace WebMarketRezorApp.Pages
{
    public class FormElementsModel : PageModel
    {
        //Make Element prop for resive info from FormElements
        public Elements Element { get; set; }
        public void OnGet()
        {
        }
    }
}
