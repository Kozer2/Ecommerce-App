using App_Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Services
{
    public class CartService
    {
        IHttpContextAccessor hca;
        
        /*public string GetCart(Id)
        {
            if (hca.HttpContext.User.IsAuthenticated)
                return hca.HttpContext.User.Identity.Name;

            string CartId = hca.HttpContext.Request.Cookies["CardId"];
            if (string.IsNullOrEmpty(cartId))
            {
                CartId = Guid.NewGuid().ToString();
                hca.HttpContext.Response.Cookies["CartId"] = CartId;
            }
        }*/

        
            

    }
}
