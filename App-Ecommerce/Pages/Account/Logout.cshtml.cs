using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Ecommerce.Services.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App_Ecommerce.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly IUserService userService;

        public LogoutModel(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult OnGet()
        {
            return Redirect("~/");  //NotFound();
        }

        public async Task<IActionResult> OnPost()
        {
            await userService.SignOut();
            return Redirect("/");
        }

    }
}
