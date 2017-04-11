namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateTimeFieldAddedEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DateTime");
        }
    }
}
