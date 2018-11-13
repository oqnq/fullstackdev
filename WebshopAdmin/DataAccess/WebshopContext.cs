using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebshopAdmin.Models;

namespace WebshopAdmin.DataAccess
{
    public class WebshopContext : DbContext
    {
        public WebshopContext():base("WebshopContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  ensure proper table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}