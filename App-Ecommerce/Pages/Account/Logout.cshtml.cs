using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App_Ecommerce.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Redirect("~/");  //NotFound();
        }

        public async Task<IActionResult> OnPost()
        {
            return Redirect("/");
        }

    }
}
