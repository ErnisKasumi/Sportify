using Microsoft.EntityFrameworkCore;
using Sportify.Entities;
namespace Sportify.Data;
public class SportifyDbContext : DbContext
{
    public SportifyDbContext(DbContextOptions<SportifyDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductBrand> ProductBrands { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2); // 18 is the precision, 2 is the scale

        // Seed data for ProductBrand
        modelBuilder.Entity<ProductBrand>().HasData(
            new ProductBrand { Id = 1, Name = "Nike" },
            new ProductBrand { Id = 2, Name = "Adidas" },
            new ProductBrand { Id = 3, Name = "Wilson" }
        );

        // Seed data for ProductType
        modelBuilder.Entity<ProductType>().HasData(
            new ProductType { Id = 1, Name = "Footwear" },
            new ProductType { Id = 2, Name = "Apparel" },
            new ProductType { Id = 3, Name = "Equipment" }
        );

        // Seed data for Product
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Nike Running Shoes",
                Description = "Comfortable running shoes for all terrains.",
                Price = 120.00m,
                PictureUrl = "http://example.com/nike-shoes.png",
                ProductTypeId = 1,  // Footwear
                ProductBrandId = 1   // Nike
            },
            new Product
            {
                Id = 2,
                Name = "Adidas Sports Jersey",
                Description = "Lightweight and breathable sports jersey.",
                Price = 50.00m,
                PictureUrl = "http://example.com/adidas-jersey.png",
                ProductTypeId = 2,  // Apparel
                ProductBrandId = 2   // Adidas
            },
            new Product
            {
                Id = 3,
                Name = "Wilson Tennis Racket",
                Description = "Professional-grade tennis racket.",
                Price = 250.00m,
                PictureUrl = "http://example.com/wilson-racket.png",
                ProductTypeId = 3,  // Equipment
                ProductBrandId = 3   // Wilson
            }
        );
    }
}