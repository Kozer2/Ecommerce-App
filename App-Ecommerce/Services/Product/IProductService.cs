using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Services.Product
{
    public interface IProductService
    {
        Task SetCurrentProductImageUrl(string url);
    }
}
