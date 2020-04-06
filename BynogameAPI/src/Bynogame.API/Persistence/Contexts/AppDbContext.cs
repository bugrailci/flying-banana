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
                new Category { Id = 100, Name = "Knives" },
                new Category { Id = 101, Name = "Heavy" },
                new Category { Id = 102, Name = "Rifles" },
                new Category { Id = 103, Name = "SMGs" },
                new Category { Id = 104, Name = "Pistols" },
                new Category { Id = 105, Name = "Gloves" }
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
                    Name = "M9 Bayonet | Doppler (Factory New)",
                    Fiyat = 2783,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                },

                new Product
                {
                    Id = 2,
                    Name = "Huntsman Knife | Tiger Tooth (Factory New)",
                    Fiyat = 1368,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 3,
                    Name = "Stiletto Knife | Fade (Factory New)",
                    Fiyat = 2081,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100
                },
                new Product
                {
                    Id = 4,
                    Name = "Huntsman Knife | Slaughter (Minimal Wear)",
                    Fiyat = 1397,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 5,
                    Name = "Shadow Daggers | Ultraviolet (Field-Tested)",
                    Fiyat = 524,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100
                },

                new Product
                {
                    Id = 6,
                    Name = "M9 Bayonet | Marble Fade (Factory New)",
                    Fiyat = 4655,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 7,
                    Name = "Flip Knife | Autotronic (Field-Tested)",
                    Fiyat = 1172,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 8,
                    Name = "Flip Knife | Freehand (Well-Worn)",
                    Fiyat = 900,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 9,
                    Name = "Flip Knife | Ultraviolet (Field-Tested)",
                    Fiyat = 798,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 10,
                    Name = "Talon Knife | Tiger Tooth (Factory New)",
                    Fiyat = 3493,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 11,
                    Name = "Shadow Daggers | Crimson Web (Field-Tested)",
                    Fiyat = 746,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                },
                new Product
                {
                    Id = 12,
                    Name = "AK-47 | Asiimov (Field-Tested)",
                    Fiyat = 205,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },

                new Product
                {
                    Id = 13,
                    Name = "AK-47 | Redline (Field-Tested)",
                    Fiyat = 91,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 14,
                    Name = "AWP | Mortis (Field-Tested)",
                    Fiyat = 26,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 15,
                    Name = "AWP | Asiimov (Field-Tested)",
                    Fiyat = 405,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 16,
                    Name = "AK-47 | Frontside Misty (Field-Tested)",
                    Fiyat = 107,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },

                new Product
                {
                    Id = 17,
                    Name = "M4A4 | Buzz Kill (Field-Tested)",
                    Fiyat = 83,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 18,
                    Name = "AK-47 | Frontside Misty (Minimal Wear)",
                    Fiyat = 152,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 19,
                    Name = "AK-47 | The Empress (Well-Worn)",
                    Fiyat = 216,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 20,
                    Name = "AK-47 | Bloodsport (Factory New)",
                    Fiyat = 378,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 21,
                    Name = "Galil AR | Rocket Pop (Minimal Wear)",
                    Fiyat = 10,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 22,
                    Name = "M4A4 | Desolate Space (Battle-Scarred)",
                    Fiyat = 65,
                    Kaliteturu = EKaliteturu.battle_scarred,
                    CategoryId = 102,
                },
                new Product
                {
                    Id = 23,
                    Name = "M4A4 | Hellfire (Minimal Wear)",
                    Fiyat = 151,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                }
            );
        }
    }
}