namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 3),
                        Rate = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.CurrencyId)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Price = c.Decimal(storeType: "money"),
                        Currency_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Currencies", t => t.Currency_Id)
                .Index(t => t.Currency_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Currency_Id", "dbo.Currencies");
            DropIndex("dbo.Products", new[] { "Currency_Id" });
            DropIndex("dbo.Currencies", new[] { "Name" });
            DropTable("dbo.Products");
            DropTable("dbo.Currencies");
        }
    }
}
