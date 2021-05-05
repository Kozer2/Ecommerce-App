using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using App_Ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace App_Ecommerce.Pages.Products
{
    public class ShoppingCartModel : PageModel
    {

        private readonly App_Ecommerce.Data.EcommerceDbContext _context;

        public ShoppingCartModel(App_Ecommerce.Data.EcommerceDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public Product Product { get; set; }
    }
}
