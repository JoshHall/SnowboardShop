namespace Snowboarding
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;

    public class SnowGear : DbContext
    {
        // Your context has been configured to use a 'SnowGear' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Snowboarding.SnowGear' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SnowGear' 
        // connection string in the application configuration file.
        public SnowGear()
            : base("name=SnowGear")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ContactForm> ContactForms { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
    }

    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }

    public class ContactForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Review { get; set; }
    }

    public partial class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int? ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}

