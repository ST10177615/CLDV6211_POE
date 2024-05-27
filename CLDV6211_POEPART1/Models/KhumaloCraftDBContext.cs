// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // DbContext for KhumaloCraft application
    public class KhumaloCraftDBContext : DbContext
    {
        public KhumaloCraftDBContext() : base("name=cldv-sql-server.CLDV6211.dbo")
        {
        }

        // DbSet for Users
        public DbSet<User> Users { get; set; }

        // DbSet for Products
        public DbSet<Product> Products { get; set; }

        // DbSet for Orders
        public DbSet<Order> Orders { get; set; }

        // DbSet for OrderDetails
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // DbSet for Transactions
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationships and any custom configurations
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(od => od.Order)
                .WithMany()
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId);
        }
    }
}