namespace CLDV6211_POEPART1.Migrations
{
    using CLDV6211_POEPART1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CLDV6211_POEPART1.Models.KhumaloCraftDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CLDV6211_POEPART1.Models.KhumaloCraftDBContext";
        }

        protected override void Seed(CLDV6211_POEPART1.Models.KhumaloCraftDBContext context)
        {
            // Add sample users
            context.Users.AddOrUpdate(
                u => u.Email,
                new User { UserId = 1, Username = "JohnDoe", Email = "john@example.com", Password = "password123" },
new User { UserId = 2, Username = "JaneSmith", Email = "jane@example.com", Password = "password456" },
new User { UserId = 3, Username = "AliceJones", Email = "alice@example.com", Password = "password789" },
new User { UserId = 4, Username = "BobJohnson", Email = "bob@example.com", Password = "passwordabc" },
new User { UserId = 5, Username = "EmilyBrown", Email = "emily@example.com", Password = "passworddef" },
new User { UserId = 6, Username = "MichaelDavis", Email = "michael@example.com", Password = "passwordghi" },
new User { UserId = 7, Username = "JessicaLee", Email = "jessica@example.com", Password = "passwordjkl" },
new User { UserId = 8, Username = "ChristopherTaylor", Email = "christopher@example.com", Password = "passwordmno" },
new User { UserId = 9, Username = "SarahClark", Email = "sarah@example.com", Password = "passwordpqr" },
new User { UserId = 10, Username = "DanielMartinez", Email = "daniel@example.com", Password = "passwordstu" },
new User { UserId = 11, Username = "AshleyRodriguez", Email = "ashley@example.com", Password = "passwordvwx" },
new User { UserId = 12, Username = "WilliamHernandez", Email = "william@example.com", Password = "passwordyz1" },
new User { UserId = 13, Username = "AmandaLopez", Email = "amanda@example.com", Password = "password234" },
new User { UserId = 14, Username = "MatthewGonzalez", Email = "matthew@example.com", Password = "password567" },
new User { UserId = 15, Username = "OliviaWilson", Email = "olivia@example.com", Password = "password890" },
new User { UserId = 16, Username = "JamesAnderson", Email = "james@example.com", Password = "passwordabc1" },
new User { UserId = 17, Username = "SophiaThomas", Email = "sophia@example.com", Password = "passworddef2" },
new User { UserId = 18, Username = "DavidMoore", Email = "david@example.com", Password = "passwordghi3" },
new User { UserId = 19, Username = "IsabellaJackson", Email = "isabella@example.com", Password = "passwordjkl4" },
new User { UserId = 20, Username = "EmmaWhite", Email = "emma@example.com", Password = "passwordmno5" },
new User { UserId = 21, Username = "JosephHarris", Email = "joseph@example.com", Password = "passwordpqr6" },
new User { UserId = 22, Username = "BenjaminMartin", Email = "benjamin@example.com", Password = "passwordstu7" },
new User { UserId = 23, Username = "MiaThompson", Email = "mia@example.com", Password = "passwordvwx8" },
new User { UserId = 24, Username = "CharlotteGarcia", Email = "charlotte@example.com", Password = "passwordyz9" },
new User { UserId = 25, Username = "ElijahMartinez", Email = "elijah@example.com", Password = "password2340" },
new User { UserId = 26, Username = "HarperRodriguez", Email = "harper@example.com", Password = "password5671" }

            );

            // Add sample products
            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { ProductId = 1, Name = "Artisanal Candles", Description = "Hand-poured candles made from natural soy wax", Price = 12.99m, ImageUrl = "Artisanal Candles.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 2, Name = "Bespoke Jewelry", Description = "Custom-designed jewelry crafted by skilled artisans", Price = 89.99m, ImageUrl = "Bespoke Jewelry.jpg", Category = "Art", Availability = true },
new Product { ProductId = 3, Name = "Carved Wooden Sculpture", Description = "Intricately carved sculpture from reclaimed wood", Price = 69.99m, ImageUrl = "Carved Wooden Sculpture.jpg", Category = "Art", Availability = true },
new Product { ProductId = 4, Name = "Decorative Pottery", Description = "Hand-painted pottery pieces for home decor", Price = 29.99m, ImageUrl = "Decorative Pottery.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 5, Name = "Embroidered Textiles", Description = "Exquisite textiles adorned with intricate embroidery", Price = 39.99m, ImageUrl = "Embroidered Textiles.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 6, Name = "Felted Wool Hats", Description = "Warm and cozy hats handcrafted from felted wool", Price = 24.99m, ImageUrl = "Felted Wool Hats.jpg", Category = "Fashion", Availability = true },
new Product { ProductId = 7, Name = "Glassblown Ornaments", Description = "Delicate ornaments crafted using traditional glassblowing techniques", Price = 8.99m, ImageUrl = "Glassblown Ornaments.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 8, Name = "Handwoven Tapestry", Description = "Beautiful tapestry handwoven on a traditional loom", Price = 59.99m, ImageUrl = "Handwoven Tapestry.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 9, Name = "Indigo-dyed Scarves", Description = "Stylish scarves dyed with natural indigo and hand-finished", Price = 19.99m, ImageUrl = "Indigo-dyed Scarves.jpg", Category = "Fashion", Availability = true },
new Product { ProductId = 10, Name = "Jute Macrame Wall Hanging", Description = "Bohemian-style wall hanging hand-knotted from jute fibers", Price = 34.99m, ImageUrl = "Jute Macrame Wall Hanging.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 11, Name = "Knitted Baby Blanket", Description = "Soft and cozy blanket hand-knitted with love for babies", Price = 17.99m, ImageUrl = "Knitted Baby Blanket.jpeg", Category = "Kids", Availability = true },
new Product { ProductId = 12, Name = "Leather Bound Journal", Description = "Refined journal with a leather cover handcrafted for writing enthusiasts", Price = 27.99m, ImageUrl = "Leather Bound Journal.jpg", Category = "Stationery", Availability = true },
new Product { ProductId = 13, Name = "Metal Artwork", Description = "Unique metal artwork hand-forged by skilled artisans", Price = 79.99m, ImageUrl = "Metal Artwork.jpg", Category = "Art", Availability = true },
new Product { ProductId = 14, Name = "Natural Bath Bombs", Description = "Relaxing bath bombs handmade with natural ingredients", Price = 9.99m, ImageUrl = "Natural Bath Bombs.jpg", Category = "Beauty", Availability = true },
new Product { ProductId = 15, Name = "Organic Skincare Set", Description = "Gentle skincare products crafted from organic ingredients", Price = 49.99m, ImageUrl = "Organic Skincare Set.jpg", Category = "Beauty", Availability = true },
new Product { ProductId = 16, Name = "Painted Silk Scarf", Description = "Elegant silk scarf hand-painted with intricate designs", Price = 29.99m, ImageUrl = "Painted Silk Scarf.jpg", Category = "Fashion", Availability = true },
new Product { ProductId = 17, Name = "Quilted Wall Hanging", Description = "Quilted wall hanging featuring intricate patterns and stitching", Price = 45.99m, ImageUrl = "Quilted Wall Hanging.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 18, Name = "Rustic Wooden Furniture", Description = "Charming furniture pieces crafted from reclaimed wood", Price = 149.99m, ImageUrl = "Rustic Wooden Furniture.jpg", Category = "Furniture", Availability = true },
new Product { ProductId = 19, Name = "Soy Wax Melts", Description = "Aromatic soy wax melts hand-poured for a delightful fragrance experience", Price = 6.99m, ImageUrl = "Soy Wax Melts.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 20, Name = "Textured Ceramic Bowl", Description = "Artistic ceramic bowl with unique textures handcrafted by a potter", Price = 19.99m, ImageUrl = "Textured Ceramic Bowl.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 21, Name = "Upcycled Tote Bag", Description = "Stylish tote bag made from upcycled materials by skilled artisans", Price = 22.99m, ImageUrl = "Upcycled Tote Bag.jpg", Category = "Fashion", Availability = true },
new Product { ProductId = 22, Name = "Vintage-inspired Quill Pen", Description = "Classic quill pen meticulously crafted for calligraphy enthusiasts", Price = 15.99m, ImageUrl = "Vintage-inspired Quill Pen.jpg", Category = "Stationery", Availability = true },
new Product { ProductId = 23, Name = "Woven Seagrass Basket", Description = "Chic basket handwoven from sustainable seagrass fibers", Price = 32.99m, ImageUrl = "Woven Seagrass Basket.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 24, Name = "Xylography Print", Description = "Hand-carved woodblock print created through traditional xylography techniques", Price = 14.99m, ImageUrl = "Xylography Print.jpg", Category = "Art", Availability = true },
new Product { ProductId = 25, Name = "Yarn Wall Art", Description = "Whimsical wall art crafted from colorful yarn in various patterns", Price = 27.99m, ImageUrl = "Yarn Wall Art.jpg", Category = "Home Decor", Availability = true },
new Product { ProductId = 26, Name = "Zen Garden Set", Description = "Tranquil zen garden set handcrafted for stress relief and relaxation", Price = 39.99m, ImageUrl = "Zen Garden Set.jpg", Category = "Home Decor", Availability = true }
) ;


            // Save changes
            context.SaveChanges();
        }
    }
}
