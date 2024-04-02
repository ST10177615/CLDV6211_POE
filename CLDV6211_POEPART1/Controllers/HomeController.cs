// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult MyWork()
        {
            // Fetch products from database or mock data
            List<Product> products = GetProductsFromDatabaseOrMock();
            return View(products);
        }

        private List<Product> GetProductsFromDatabaseOrMock()
        {
            // Implement logic to fetch products from database or mock data
            // For demonstration purposes, I'll use mock data
            return new List<Product>
        {
new Product { Id = 1, Name = "Artisanal Candles", Description = "Hand-poured candles made from natural soy wax", Price = 12.99m, ImageUrl = "Artisanal Candles.jpg" },
new Product { Id = 2, Name = "Bespoke Jewelry", Description = "Custom-designed jewelry crafted by skilled artisans", Price = 89.99m, ImageUrl = "Bespoke Jewelry.jpg" },
new Product { Id = 3, Name = "Carved Wooden Sculpture", Description = "Intricately carved sculpture from reclaimed wood", Price = 69.99m, ImageUrl = "Carved Wooden Sculpture.jpg" },
new Product { Id = 4, Name = "Decorative Pottery", Description = "Hand-painted pottery pieces for home decor", Price = 29.99m, ImageUrl = "Decorative Pottery.jpg" },
new Product { Id = 5, Name = "Embroidered Textiles", Description = "Exquisite textiles adorned with intricate embroidery", Price = 39.99m, ImageUrl = "Embroidered Textiles.jpg" },
new Product { Id = 6, Name = "Felted Wool Hats", Description = "Warm and cozy hats handcrafted from felted wool", Price = 24.99m, ImageUrl = "Felted Wool Hats.jpg" },
new Product { Id = 7, Name = "Glassblown Ornaments", Description = "Delicate ornaments crafted using traditional glassblowing techniques", Price = 8.99m, ImageUrl = "Glassblown Ornaments.jpg" },
new Product { Id = 8, Name = "Handwoven Tapestry", Description = "Beautiful tapestry handwoven on a traditional loom", Price = 59.99m, ImageUrl = "Handwoven Tapestry.jpg" },
new Product { Id = 9, Name = "Indigo-dyed Scarves", Description = "Stylish scarves dyed with natural indigo and hand-finished", Price = 19.99m, ImageUrl = "Indigo-dyed Scarves.jpg" },
new Product { Id = 10, Name = "Jute Macrame Wall Hanging", Description = "Bohemian-style wall hanging hand-knotted from jute fibers", Price = 34.99m, ImageUrl = "Jute Macrame Wall Hanging.jpg" },
new Product { Id = 11, Name = "Knitted Baby Blanket", Description = "Soft and cozy blanket hand-knitted with love for babies", Price = 17.99m, ImageUrl = "Knitted Baby Blanket.jpeg" },
new Product { Id = 12, Name = "Leather Bound Journal", Description = "Refined journal with a leather cover handcrafted for writing enthusiasts", Price = 27.99m, ImageUrl = "Leather Bound Journal.jpg" },
new Product { Id = 13, Name = "Metal Artwork", Description = "Unique metal artwork hand-forged by skilled artisans", Price = 79.99m, ImageUrl = "Metal Artwork.jpg" },
new Product { Id = 14, Name = "Natural Bath Bombs", Description = "Relaxing bath bombs handmade with natural ingredients", Price = 9.99m, ImageUrl = "Natural Bath Bombs.jpg" },
new Product { Id = 15, Name = "Organic Skincare Set", Description = "Gentle skincare products crafted from organic ingredients", Price = 49.99m, ImageUrl = "Organic Skincare Set.jpg" },
new Product { Id = 16, Name = "Painted Silk Scarf", Description = "Elegant silk scarf hand-painted with intricate designs", Price = 29.99m, ImageUrl = "Painted Silk Scarf.jpg" },
new Product { Id = 17, Name = "Quilted Wall Hanging", Description = "Quilted wall hanging featuring intricate patterns and stitching", Price = 45.99m, ImageUrl = "Quilted Wall Hanging.jpg" },
new Product { Id = 18, Name = "Rustic Wooden Furniture", Description = "Charming furniture pieces crafted from reclaimed wood", Price = 149.99m, ImageUrl = "Rustic Wooden Furniture.jpg" },
new Product { Id = 19, Name = "Soy Wax Melts", Description = "Aromatic soy wax melts hand-poured for a delightful fragrance experience", Price = 6.99m, ImageUrl = "Soy Wax Melts.jpg" },
new Product { Id = 20, Name = "Textured Ceramic Bowl", Description = "Artistic ceramic bowl with unique textures handcrafted by a potter", Price = 19.99m, ImageUrl = "Textured Ceramic Bowl.jpg" },
new Product { Id = 21, Name = "Upcycled Tote Bag", Description = "Stylish tote bag made from upcycled materials by skilled artisans", Price = 22.99m, ImageUrl = "Upcycled Tote Bag.jpg" },
new Product { Id = 22, Name = "Vintage-inspired Quill Pen", Description = "Classic quill pen meticulously crafted for calligraphy enthusiasts", Price = 15.99m, ImageUrl = "Vintage-inspired Quill Pen.jpg" },
new Product { Id = 23, Name = "Woven Seagrass Basket", Description = "Chic basket handwoven from sustainable seagrass fibers", Price = 32.99m, ImageUrl = "Woven Seagrass Basket.jpg" },
new Product { Id = 24, Name = "Xylography Print", Description = "Hand-carved woodblock print created through traditional xylography techniques", Price = 14.99m, ImageUrl = "Xylography Print.jpg" },
new Product { Id = 25, Name = "Yarn Wall Art", Description = "Whimsical wall art crafted from colorful yarn in various patterns", Price = 27.99m, ImageUrl = "Yarn Wall Art.jpg" },
new Product { Id = 26, Name = "Zen Garden Set", Description = "Tranquil zen garden set handcrafted for stress relief and relaxation", Price = 39.99m, ImageUrl = "Zen Garden Set.jpg" }

            // Add more products as needed
        };
        }
    }
}