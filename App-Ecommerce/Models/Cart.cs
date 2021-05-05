using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Models
{
    public class Cart
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }
    }
}
