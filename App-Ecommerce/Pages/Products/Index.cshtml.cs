using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using App_Ecommerce.Data;
using App_Ecommerce.Models;

namespace App_Ecommerce.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly App_Ecommerce.Data.EcommerceDbContext _context;

        public IndexModel(App_Ecommerce.Data.EcommerceDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
