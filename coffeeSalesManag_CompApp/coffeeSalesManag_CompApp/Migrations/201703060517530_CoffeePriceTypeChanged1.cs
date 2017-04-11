namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoffeePriceTypeChanged1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coffees", "CoffeeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coffees", "CoffeeName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
