using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebshopAdmin.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
        }

        public int ID { get; set; }
        [Display(Name="Név")]
        public string Name { get; set; }
    }
}