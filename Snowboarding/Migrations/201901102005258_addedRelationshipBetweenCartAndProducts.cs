namespace Snowboarding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRelationshipBetweenCartAndProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Carts", "ProductID", c => c.Int());
            CreateIndex("dbo.Carts", "ProductID");
            AddForeignKey("dbo.Carts", "ProductID", "dbo.Products", "Id");
            DropColumn("dbo.Carts", "Name");
            DropColumn("dbo.Carts", "Price");
            DropColumn("dbo.Carts", "Size");
            DropColumn("dbo.Carts", "Color");
            DropColumn("dbo.Carts", "Material");
            DropColumn("dbo.Carts", "Type");
            DropColumn("dbo.Carts", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "Image", c => c.String());
            AddColumn("dbo.Carts", "Type", c => c.String());
            AddColumn("dbo.Carts", "Material", c => c.String());
            AddColumn("dbo.Carts", "Color", c => c.String());
            AddColumn("dbo.Carts", "Size", c => c.String());
            AddColumn("dbo.Carts", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Carts", "Name", c => c.String());
            DropForeignKey("dbo.Carts", "ProductID", "dbo.Products");
            DropIndex("dbo.Carts", new[] { "ProductID" });
            DropColumn("dbo.Carts", "ProductID");
            DropColumn("dbo.Carts", "Quantity");
        }
    }
}
