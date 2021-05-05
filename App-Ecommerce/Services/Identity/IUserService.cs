using App_Ecommerce.Models.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace App_Ecommerce.Services.Identity
{
    public interface IUserService
    {
        Task<ApplicationUser> Register(RegisterData data, string role, ModelStateDictionary modelState);

        Task<bool> SignIn(LoginData data);
        Task SignOut();

        Task<ApplicationUser> GetCurrentUser();
    }
}