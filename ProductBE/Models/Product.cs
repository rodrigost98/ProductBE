using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductBE.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name="Product name")]
        public string Name { get; set; }
        public double Price { get; set; }

    }
}