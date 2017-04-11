namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblNameChanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ManageSales", newName: "Sales");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Sales", newName: "ManageSales");
        }
    }
}
