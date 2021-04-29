using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Services
{
    public interface IFileService
    {
        Task<string> Create(IFormFile productImage);
    }
}
