using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Description of Product")]
        public string ProductDescription { get; set; }
    }
}
