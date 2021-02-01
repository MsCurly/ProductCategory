using Microsoft.EntityFrameworkCore;
using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Data
{
    class miniShopDbContext : DbContext
    {
        public DbSet<Product> Products {get; set;}

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(category => category.Products)
                        .WithOne(product => product.Category)
                        .HasForeignKey(product => product.CategoryId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Databasein nerede oluşacağını söylüyoruz
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=UrunKategoriDb;Integrated Security=yes;");

            }
        }
    }
}
