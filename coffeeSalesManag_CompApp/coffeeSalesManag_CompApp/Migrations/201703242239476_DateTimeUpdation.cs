namespace coffeeSalesManag_CompApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeUpdation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sales", "Time", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Sales", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "Time");
            DropColumn("dbo.Sales", "Date");
        }
    }
}
