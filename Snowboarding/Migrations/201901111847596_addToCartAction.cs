namespace Snowboarding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addToCartAction : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carts", newName: "CartItems");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CartItems", newName: "Carts");
        }
    }
}
