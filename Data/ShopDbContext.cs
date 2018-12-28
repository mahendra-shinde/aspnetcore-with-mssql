using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using DotNETCoreGettingStarted.Models;
using JetBrains.Annotations;

namespace DotNETCoreGettingStarted.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext( DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id)
                .HasName("PK_CategoryId"); 

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id)
                .HasName("PK_ProductId");  

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c=>c.Products)
                .HasForeignKey(p=>p.CategoryId)
                .HasConstraintName("FK_CategoryId_Product");
        }

        
    }
}