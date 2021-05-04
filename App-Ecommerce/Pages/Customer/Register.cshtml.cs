using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Ecommerce.Models.Identity;
using App_Ecommerce.Services.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App_Ecommerce.Pages.Customer
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService userService;

        public RegisterModel(IUserService userService)
        {
            this.userService = userService;
        }

        [BindProperty]
        public RegisterData Input { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            await userService.Register(Input, ModelState);
            if (!ModelState.IsValid)
                return Page();

            return  Redirect("~/");
        }
    }
}
