namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Construction : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ConstructionItems");
            AlterColumn("dbo.ConstructionItems", "ItemId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ConstructionItems", "ItemId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ConstructionItems");
            AlterColumn("dbo.ConstructionItems", "ItemId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ConstructionItems", "ItemId");
        }
    }
}
