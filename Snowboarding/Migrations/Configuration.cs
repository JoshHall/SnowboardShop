namespace Snowboarding.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Snowboarding.SnowGear>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Snowboarding.SnowGear context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.Add(new Product
            {
                Name = "Snowboard",
                Price = 1.99m,
                Image = "./images/broken.jpg",
                Color = "Red",
                Size = "Large",
                Material = "Plastic",
                Type = "Snowboard"
            });
            context.SaveChanges();
        }
    }
}
