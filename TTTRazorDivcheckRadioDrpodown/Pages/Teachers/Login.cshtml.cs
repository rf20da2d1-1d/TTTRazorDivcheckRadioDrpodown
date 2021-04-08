using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TTTRazorDivcheckRadioDrpodown.Pages.Teachers
{
    public class LoginModel : PageModel
    {
        [BindProperty] public String Name { get; set; }
        [BindProperty] public String Kodeord { get; set; }



        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Name == "Peter" && Kodeord == "1234")
            {
                HttpContext.Session.SetString("User", "Peter");
            }

        }


    }
}
