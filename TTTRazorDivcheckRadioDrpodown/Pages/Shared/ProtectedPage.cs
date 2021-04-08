using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TTTRazorDivcheckRadioDrpodown.Pages.Shared
{
    public abstract class ProtectedPage:PageModel
    {

        public IActionResult OnGet()
        {
            if (!HttpContext.Session.Keys.Contains("User"))
            {
                return RedirectToPage("Index");
            }

            return GetRequest();
        }

        

        public IActionResult OnPost()
        {
            if (!HttpContext.Session.Keys.Contains("User"))
            {
                return RedirectToPage("Index");
            }

            return PostRequest();
        }

        protected abstract IActionResult GetRequest();
        protected abstract IActionResult PostRequest();
    }
}
