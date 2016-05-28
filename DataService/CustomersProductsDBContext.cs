using DataService.Entities;
using DataService.EntitiesConfig;
using DataService.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class CustomersProductsDBContext : DbContext
    {
        public CustomersProductsDBContext()
            : base("name=CustomersProductsDB") {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CustomersProductsDBContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CustomersProductsDBContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CustomersProductsDBContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CustomersProductsDBContext>());
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<CustomersProducts> CustomersProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new CustomersProductsConfig());
        }
    }
}
