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
            // checks for missing required tags
            if (!ModelState.IsValid)
                return View(data);

            await userService.Register(data, ModelState);
            // checks for errors on registration
            if (!ModelState.IsValid)
                return View(data);
            // this redirects the user to the welcome page once an account is made
            return RedirectToAction(nameof(Welcome));
        }

        [HttpGet("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginData data)
        {
            if (!ModelState.IsValid)
                return View();

            if (!await userService.SignIn(data))
            {
                ModelState.AddModelError(nameof(LoginData.Password), "Username or Password were incorrect.");
                return View(data);
            }
                
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
