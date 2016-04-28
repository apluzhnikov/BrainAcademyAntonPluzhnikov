namespace DataService
{
    using Migrations;
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EntitiesConfig;

    public class FlightsManagerDbContext : DbContext
    {
        public FlightsManagerDbContext()
            : base("name=FlightsManagerDbCodeFirst") {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<FlightsManagerDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FlightsManagerDbContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FlightsManagerDbContext, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<Currency>().HasKey(i => i.Id).Property(i=>i.Id).HasColumnName("CurrencyId");
            modelBuilder.Entity<Currency>().Property(i => i.Name).HasMaxLength(3).IsRequired().IsUnicode();*/

            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new CurrencyConfig());

        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}