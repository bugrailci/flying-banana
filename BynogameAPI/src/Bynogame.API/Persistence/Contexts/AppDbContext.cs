using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using BYNOGAME.API.Domain.Models;

namespace BYNOGAME.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "Býçak" },
                new Category { Id = 101, Name = "AWP" },
                new Category { Id = 102, Name = "AK-47" },
                new Category { Id = 103, Name = "SMG" },
                new Category { Id = 104, Name = "Desert-Eagle" },
                new Category { Id = 105, Name = "Eldiven" }
            );

            builder.Entity<Product>().ToTable("Guns & Stuff");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Fiyat).IsRequired();
            builder.Entity<Product>().Property(p => p.Kaliteturu).IsRequired();

            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "Worm God(BS)",
                    Fiyat = 5,
                    Kaliteturu = EKaliteturu.Battle_scarred,
                    CategoryId = 101
                },

                new Product
                {
                    Id = 131,
                    Name = "Dragonlore(FN)",
                    Fiyat = 5500,
                    Kaliteturu = EKaliteturu.Factory_new,
                    CategoryId = 101,
                },
                new Product
                {
                    Id = 3,
                    Name = "Worm God(MR)",
                    Fiyat = 40,
                    Kaliteturu = EKaliteturu.Mid_Range,
                    CategoryId = 100
                },
                new Product
                {
                    Id = 5,
                    Name = "Örümcek Karambit(FN)",
                    Fiyat = 1500,
                    Kaliteturu = EKaliteturu.Factory_new,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 10,
                    Name = "AK-47 Asimov(BS)",
                    Fiyat = 80,
                    Kaliteturu = EKaliteturu.Battle_scarred,
                    CategoryId = 102
                },

                new Product
                {
                    Id = 101,
                    Name = "Red-Poison Desert Eagle(FN)",
                    Fiyat = 300,
                    Kaliteturu = EKaliteturu.Factory_new,
                    CategoryId = 101,
                },
                new Product
                {
                    Id = 12,
                    Name = "Terrorist-Green",
                    Fiyat = 500,
                    CategoryId = 105
                },
                new Product
                {
                    Id = 14,
                    Name = "Midnight Bayoneet(FN)",
                    Fiyat = 1000,
                    Kaliteturu = EKaliteturu.Factory_new,
                    CategoryId = 105,
                }
            );
        }
    }
}