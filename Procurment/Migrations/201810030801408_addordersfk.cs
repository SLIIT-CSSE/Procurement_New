namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addordersfk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "OrderItemId", "dbo.OrderItems");
            DropIndex("dbo.Orders", new[] { "OrderItemId" });
            AddColumn("dbo.OrderItems", "ConstructionItemId", c => c.String());
            AddColumn("dbo.OrderItems", "ConstructionItem_ItemId", c => c.String(maxLength: 128));
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String(maxLength: 128));
            CreateIndex("dbo.OrderItems", "OrderId");
            CreateIndex("dbo.OrderItems", "ConstructionItem_ItemId");
            AddForeignKey("dbo.OrderItems", "ConstructionItem_ItemId", "dbo.ConstructionItems", "ItemId");
            AddForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders", "OrderId");
            DropColumn("dbo.OrderItems", "ItemId");
            DropColumn("dbo.Orders", "OrderItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderItemId", c => c.String(maxLength: 128));
            AddColumn("dbo.OrderItems", "ItemId", c => c.String());
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "ConstructionItem_ItemId", "dbo.ConstructionItems");
            DropIndex("dbo.OrderItems", new[] { "ConstructionItem_ItemId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String());
            DropColumn("dbo.OrderItems", "ConstructionItem_ItemId");
            DropColumn("dbo.OrderItems", "ConstructionItemId");
            CreateIndex("dbo.Orders", "OrderItemId");
            AddForeignKey("dbo.Orders", "OrderItemId", "dbo.OrderItems", "OrderItemId");
        }
    }
}
