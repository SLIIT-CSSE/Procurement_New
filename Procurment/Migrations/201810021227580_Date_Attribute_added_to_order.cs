namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date_Attribute_added_to_order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Date");
        }
    }
}
