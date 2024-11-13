using Microsoft.EntityFrameworkCore;
using WebScraperAPIPrototype.Data.Entity;

namespace WebScraperAPIPrototype.Data
{
    public class WebScraperDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<VitaminsMass> VitaminsMasses { get; set; }
        public DbSet<URL> URLs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<IngredientsProduct> IngredientsProducts { get; set; }
        
        public WebScraperDBContext(DbContextOptions<WebScraperDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite key for Product
            modelBuilder.Entity<Product>()
                .HasKey(p => new { p.ProductId, p.ProductName, p.ServingSize });

            // Configure the relationship between Product and Nutrition
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Nutrition)
                .WithOne(n => n.Product)
                .HasForeignKey<Product>(p => p.NutritionId);

            // Configure the relationship between Product and Brand
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithOne(b => b.Product)
                .HasForeignKey<Product>(p => p.BrandId);

            // Configure the relationship between Product and Categories
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(p => p.CategoryId);

            // Configure the relationship between Product and Countries
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Country)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(p => p.CountryOfOrigin);

            // Configure composite key for URL
            modelBuilder.Entity<URL>()
                .HasKey(u => new { u.UrlId, u.ProductId, u.Url });

            // 1:Many relationship between Product and URLs
            modelBuilder.Entity<Product>()
                .HasMany(p => p.URLs)
                .WithOne(u => u.Product)
                .HasForeignKey(u => u.ProductId);

            // Configure composite key for IngredientsProduct
            modelBuilder.Entity<IngredientsProduct>()
                .HasKey(ip => new { ip.IngredientsProductId, ip.ProductId, ip.IngredientId });

            // Configure many-to-many relationship between Product and Ingredients via IngredientsProduct
            modelBuilder.Entity<IngredientsProduct>()
                .HasOne(ip => ip.Ingredient)
                .WithMany(i => i.IngredientsProducts)
                .HasForeignKey(ip => ip.IngredientId);

            modelBuilder.Entity<IngredientsProduct>()
                .HasOne(ip => ip.Product)
                .WithMany(p => p.IngredientsProducts)
                .HasForeignKey(ip => ip.ProductId);

            // Configure one-to-one relationships between Nutrition and VitaminsMass
            modelBuilder.Entity<Nutrition>()
                .HasOne(n => n.VitaminsMass)
                .WithMany(v => v.Nutritions)
                .HasForeignKey(n => n.VitaminsMassId);

            // Primary keys for other entities
            modelBuilder.Entity<Nutrition>()
                .HasKey(n => n.NutritionId);

            modelBuilder.Entity<VitaminsMass>()
                .HasKey(v => v.VitaminsMassId);

            modelBuilder.Entity<Brand>()
                .HasKey(b => b.BrandId);

            modelBuilder.Entity<Countries>()
                .HasKey(c => c.CountryId);

            modelBuilder.Entity<Categories>()
                .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Ingredients>()
                .HasKey(i => i.IngredientsId);
        }
    }
}