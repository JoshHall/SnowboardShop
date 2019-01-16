namespace Snowboarding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "Image", c => c.String());
            AddColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Image");
            DropColumn("dbo.Carts", "Image");
        }
    }
}
