using App_Ecommerce.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Ecommerce.Models;

namespace App_Ecommerce.Data
{
    public class EcommerceDbContext : IdentityDbContext<ApplicationUser>
    {
        public EcommerceDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
