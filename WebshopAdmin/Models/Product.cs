using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebshopAdmin.App_Code;

namespace WebshopAdmin.Models
{
    public class Product
    {
        public Product()
        {
            CreatedOn = UpdatedOn = DateTime.Now;
        }
        //  to be called on changes internally
        internal void Update()
        {
            UpdatedOn = DateTime.Now;
        }
        
        public int ID { get; set; }
        public virtual ProductCategory Category { get; set; }
        //[Key]
        [ForeignKey("Category")]
        [Display(Name = "Kategória")] //does not apply to view...
        public int ProductCategoryID { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 6, ErrorMessage = "a {0} legalább {1}, legfeljebb {2} hosszú lehet.")]
        [Display(Name = "Megnevezés")]
        public string Name { get; set; }
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Ár")]
        public int Price { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 5, ErrorMessage = "a {0} legalább {1}, legfeljebb {2} hosszú lehet.")]
        [Display(Name = "Feltöltő neve")]
        public string OwnerName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [EmailValidation]
        public string OwnerEmail { get; set; }
        [Required]
        [Editable(false)]
        public DateTime CreatedOn { get; set; }
        [Required]
        [Editable(false)]
        public DateTime UpdatedOn { get; set; }

    }
}