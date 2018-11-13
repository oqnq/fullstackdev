using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebshopAdmin.Models;

namespace WebshopAdmin.DataAccess
{
    public class WebshopInitializer: DropCreateDatabaseIfModelChanges<WebshopContext>
    {
        protected override void Seed(WebshopContext context)
        {
            context.ProductCategories.Add(new ProductCategory() { ID = 0, Name = "food" });
            context.ProductCategories.Add(new ProductCategory() { ID = 1, Name = "non-food" });
            context.SaveChanges();
            context.Products.Add(new Product() { ID = 0, Name = "good food", ProductCategoryID = 1, CreatedOn = DateTime.Now, Description = "delicious stuff", OwnerEmail = "sducsai2@graphisoft.com", OwnerName = "Sanyi 1", Price = 1.25M, UpdatedOn = DateTime.Now });
            context.SaveChanges();
        }
    }
}