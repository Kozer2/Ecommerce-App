using App_Ecommerce.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Services.Identity
{
    public class IdentityUserService : IUserService
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public IdentityUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<ApplicationUser> Register(RegisterData data, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser
            {
                
                Email = data.Email,
                FirstName = data.FirstName,
                LastName = data.LastName,
                UserName = data.UserName,
                // PasswordHash = data.Password, // NO
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (result.Succeeded)
            {
                return user;
            }

            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? nameof(data.Password) :
                    error.Code.Contains("Email") ? nameof(data.Email) :
                    error.Code.Contains("UserName") ? nameof(data.Email) :
                    error.Code.Contains("FirstName") ? nameof(data.FirstName) :
                    error.Code.Contains("LastName") ? nameof(data.LastName) :
                    "";
                modelState.AddModelError(errorKey, error.Description);
            }
            return null;
        }

        public async Task<bool> SignIn(LoginData data)
        {
           var result = await signInManager.PasswordSignInAsync(data.UserName, data.Password, false, false);
            return result.Succeeded;
        }
    }
}
