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
        private readonly IEmailService emailService;



        public IdentityUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailService emailService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailService = emailService;
        }

        public Task<ApplicationUser> GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> Register(RegisterData data, string role, ModelStateDictionary modelState)
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
                if(role == Role.Administrator)
                {
                    var admins = await userManager.GetUsersInRoleAsync(Role.Administrator);
                    if(admins.Count == 0)
                        await userManager.AddToRoleAsync(user, role);
                }
                else
                {
                    await userManager.AddToRoleAsync(user, role);
                }
                await signInManager.SignInAsync(user, false);

                // user email service setup
                await emailService.SendEmail(user.Email, "Thank you for signing up", "We appreciate your business");
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

        public async Task SignOut()
        {
            await signInManager.SignOutAsync();
        }
    }
}
