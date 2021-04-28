using System.ComponentModel.DataAnnotations;

namespace App_Ecommerce.Models.Identity
{
    public class LoginData
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get;  set; }
    }
}
