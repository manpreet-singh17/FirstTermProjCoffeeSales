namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoffeePriceTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coffees", "CoffePrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coffees", "CoffePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
