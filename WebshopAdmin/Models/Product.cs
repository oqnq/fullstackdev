using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebshopAdmin.Models
{
    public class Product
    {
        public Product()
        {
            CreatedOn = DateTime.Now;
        }
        private void Update()
        {
            UpdatedOn = DateTime.Now;
        }
        public int ID { get; set; }
        public virtual ProductCategory Category { get; set; }
        [Key]
        [ForeignKey("Category")]
        public int ProductCategoryID { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 6)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal? Price { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 5)]
        public string OwnerName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string OwnerEmail { get; set; }
        [Required]
        [Editable(false)]
        public DateTime CreatedOn { get; set; }
        [Required]
        [Editable(false)]
        public DateTime UpdatedOn { get; set; }

    }
}