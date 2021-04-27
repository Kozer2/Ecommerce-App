using App_Ecommerce.Models.Identity;
using App_Ecommerce.Services.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterData data)
        {
           await userService.Register(data, ModelState);
            // this redirects the user to the welcome page once an account is made
            return RedirectToAction(nameof(Welcome));
        }

        [HttpGet("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
