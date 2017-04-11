namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manageSaleTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManageSales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CoffeeName = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        AddBy = c.String(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManageSales");
        }
    }
}
