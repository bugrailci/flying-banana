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
                    CategoryId = 101,
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
                }
            );
        }
    }
}