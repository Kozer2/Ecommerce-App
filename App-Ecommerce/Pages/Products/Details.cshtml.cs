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
    public class DetailsModel : PageModel
    {
        private readonly App_Ecommerce.Data.EcommerceDbContext _context;

        public DetailsModel(App_Ecommerce.Data.EcommerceDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

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
    }
}
