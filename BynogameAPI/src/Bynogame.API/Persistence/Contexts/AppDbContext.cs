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
            builder.Entity<Product>().Property(p => p.URL).IsRequired();

            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "M9 Bayonet | Doppler (Factory New)",
                    Fiyat = 2783,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJf3qr3czxb49KzgL-KmsjwPKvBmm5D19V5i_rEprP5gVO8v11lZj-gIYbDclRqMA7Zq1S7lOm-0Za6753KmHoxvnQh5y7ZyhWxiRwecKUx0iL1oy6z/300fx300f",
                },

                new Product
                {
                    Id = 2,
                    Name = "Huntsman Knife | Tiger Tooth (Factory New)",
                    Fiyat = 1368,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfx_LLZTRB7dCJlY60g_7zNqnumXlQ5sJ0teXI8oThxg3i-hBrZjrxLIHBd1VsMFjY_1jrl-_s0MK06c_Pyno3vSAlt37cnRypwUYbNzTTgSE",
                },
                new Product
                {
                    Id = 3,
                    Name = "Stiletto Knife | Fade (Factory New)",
                    Fiyat = 2081,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfwOfBfThW-NOJlYG0kfbwNoTdn2xZ_Ityj7rDp4qjjFC3-xJuMGz3IIWUcA5oZFvVrlnokO-90JfttJ2dziQypGB8soIAQfsS/300fx300f",
                },
                new Product
                {
                    Id = 4,
                    Name = "Huntsman Knife | Slaughter (Minimal Wear)",
                    Fiyat = 1397,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfx_LLZTRB7dCJlY20jfL2IbrummJW4NE_27uYo4ii3lDn_xVtNmz0J46QcAJtaVjYrFK4xOvngce_tMyYn3Qx7D5iuyi6YsDq_w/300fx300f",
                },
                new Product
                {
                    Id = 5,
                    Name = "Shadow Daggers | Ultraviolet (Field-Tested)",
                    Fiyat = 524,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfw-bbeQJR4-OmgZKbm_LLPr7Vn35cppAh3bnHrNzw2QDk-RBsNjyhdYfAegY6MAvY_VK9wr-615K8v5_IzSR9-n51mmmH1WU/300fx300f",
                },

                new Product
                {
                    Id = 6,
                    Name = "M9 Bayonet | Marble Fade (Factory New)",
                    Fiyat = 4655,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJf3qr3czxb49KzgL-Kmsj5MqnTmm5u7sR1j9bN_Iv9nBrj-EE-YTrzcYXGcA85aF7YqQLtwb3o0MXo6Z3Nynoy6Ckr4CnUmBe3n1gSOfoXRhVR/300fx300f",
                },
                new Product
                {
                    Id = 7,
                    Name = "Flip Knife | Autotronic (Field-Tested)",
                    Fiyat = 1172,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJf1f_BYQJF_-OwmImbqPbhJ7TFhGRf4cZOh-zF_Jn4xgywrhdlYDjxJdWcJg9saAvWrgO7k7zq0MC76Z_BzHo2vHUit3zZmBepwUYbMN7IGa4/300fx300f",
                },
                new Product
                {
                    Id = 8,
                    Name = "Flip Knife | Freehand (Well-Worn)",
                    Fiyat = 900,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJf1f_BYQJD4eO7lZKAkvPLJqvum25V4dB8xO2V8N3wigXgrhY9azjxdobEIQFoaF3U8wS4lL3q1pW5tJicwXc2siY8pSGKfr8IRQI/300fx300f",
                },
                new Product
                {
                    Id = 9,
                    Name = "Flip Knife | Ultraviolet (Field-Tested)",
                    Fiyat = 798,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJf1f_BYQJR4-OmgZKbm_LLPr7Vn35cppAh2-iQpoik3wS1r0RvZz_6cIedcQQ6YVvY8wS7xu68jMK5vpjPzHp9-n51lc8UCJg/300fx300f",
                },
                new Product
                {
                    Id = 10,
                    Name = "Talon Knife | Tiger Tooth (Factory New)",
                    Fiyat = 3493,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 100,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfxPrMfipP7dezhr-KmcjgOrzUhFRe-sR_jez--YXygED6rUo_Zj32I4XEc1A8YQqBrFm_yefn0cS7u8mfmHQ17iAn5niPzRy11wYMMLKgzlhJog/300fx300f",
                },
                new Product
                {
                    Id = 11,
                    Name = "Shadow Daggers | Crimson Web (Field-Tested)",
                    Fiyat = 746,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 100,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpovbSsLQJfw-bbeQJK9eOhkYKYqPrxN7LEmyUCu5d33L-XoInwjQKx-ERqMGjzIYSRcQY4YlrWqAfswLzs1MXp6J_P1zI97UtCWW8t/300fx300f",
                },
                new Product
                {
                    Id = 12,
                    Name = "AK-47 | Asiimov (Field-Tested)",
                    Fiyat = 205,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV092lnYmGmOHLPr7Vn35cppQiiOuQpoml3wW18xdkNTjxd9CQdwM_ZlrT-lW_kLzu0560vp-azXJ9-n51Q5-Fea0/300fx300f",
                },

                new Product
                {
                    Id = 13,
                    Name = "AK-47 | Redline (Field-Tested)",
                    Fiyat = 91,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV09-5lpKKqPrxN7LEmyVQ7MEpiLuSrYmnjQO3-UdsZGHyd4_Bd1RvNQ7T_FDrw-_ng5Pu75iY1zI97bhLsvQz/300fx300f",
                },
                new Product
                {
                    Id = 14,
                    Name = "AWP | Mortis (Field-Tested)",
                    Fiyat = 26,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FABz7PLfYQJG6d2inL-GkvP9JrafzzxUvMF0ib6Z9NSg0Abg_kc9MGn2cdeSclA2Ml_R_AK9xOvrhsC76YOJlyWzRFT-mw/300fx300f",
                },
                new Product
                {
                    Id = 15,
                    Name = "AWP | Asiimov (Field-Tested)",
                    Fiyat = 405,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAR17PLfYQJD_9W7m5a0mvLwOq7c2G9SupUijOjAotyg3w2x_0ZkZ2rzd4OXdgRoYQuE8gDtyL_mg5K4tJ7XiSw0WqKv8kM/300fx300f",
                },
                new Product
                {
                    Id = 16,
                    Name = "AK-47 | Frontside Misty (Field-Tested)",
                    Fiyat = 107,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV08u_mpSOhcjnI7TDglRc7cF4n-SP8I6g2gW2r0RtZmjxLYfDIQ46Ml_X_QPtwb-8g5S46ZXKnXU2uiZwtGGdwUI5DKpcCA/300fx300f",
                },

                new Product
                {
                    Id = 17,
                    Name = "M4A4 | Buzz Kill (Field-Tested)",
                    Fiyat = 83,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhnwMzFJTwW08-zl5SEhcj5Nr_Yg2Yfu8Ek0-uXrNyh3gbn_0M-YzqmIoLAJFA6M1vU_Fe7lLrrgp6_u52cyGwj5HcviqwPgQ/300fx300f",
                },
                new Product
                {
                    Id = 18,
                    Name = "AK-47 | Frontside Misty (Minimal Wear)",
                    Fiyat = 152,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV08u_mpSOhcjnI7TDglRd4cJ5nqeWrdn02Ay1rhA4amD1cNXDJFU4N1vY-Va9l7q8gpW6tZqcz3Ji6yZz-z-DyDzjuIse/300fx300f",
                },
                new Product
                {
                    Id = 19,
                    Name = "AK-47 | The Empress (Well-Worn)",
                    Fiyat = 216,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV09m7hJKOhOTLPr7Vn35cppMh2L2VrN-h2geyqhc-MD3xJYecIANrMwvZ8wK8wr3nhJC6vJ2dy3B9-n51Yx1fd-M/300fx300f",
                },
                new Product
                {
                    Id = 20,
                    Name = "AK-47 | Bloodsport (Factory New)",
                    Fiyat = 378,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 102,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV0966m4-PhOf7Ia_ummJW4NE_3rnHpdujjgK28kE5Y2Gid9WWdQ44YVHS-VS9wr--jJG6tJrAzCBh6D5iuyjdE47G3Q/300fx300f",
                },
                new Product
                {
                    Id = 21,
                    Name = "Galil AR | Rocket Pop (Minimal Wear)",
                    Fiyat = 10,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbupIgthwczLZAJF7dC_mIGZqOf1Ia_YlWdU-_p9g-7J4cKt3wfmrUVoN2zwcNTGe1Q-Ml_T-Fe6wOjqgMK46pTAyHBn7ihxtCyOgVXp1nGGEdIU/300fx300f",
                },
                new Product
                {
                    Id = 22,
                    Name = "M4A4 | Desolate Space (Battle-Scarred)",
                    Fiyat = 65,
                    Kaliteturu = EKaliteturu.battle_scarred,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhjxszFJTwW09izh4-HluPxDKjBl2hU1810i__Yu9-m2QzjqRI_ZWCgIIDEIA84NwzU_1C2krru0MW_6pjJzHIyvnN2tyrD30vgteaeMJk/300fx300f",
                },
                new Product
                {
                    Id = 23,
                    Name = "M4A4 | Hellfire (Minimal Wear)",
                    Fiyat = 151,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 102,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhjxszFJTwW09SzmIyNnuXxDLfYkWNFpsEi3L6UrdiljFXlr0VsNmj6dteXdFBtYFnV-VjryO3qhMe86c7BwHB9-n51JK1M_qQ/300fx300f",
                },
                new Product
                {
                    Id = 24,
                    Name = "CZ75-Auto | Tacticat (Minimal Wear)",
                    Fiyat = 4,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 104,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpotaDyfgZf1OD3cicVueOilYOfnvT1J4Tdn2xZ_It0jrDD9N7z3le28xU4ZjzxdYTHdFVoM1mC8wC-k7_r1p6775TKnCFgpGB8stXRbcWP/300fx300f",
                },
                new Product
                {
                    Id = 25,
                    Name = "USP-S | Cortex (Field-Tested)",
                    Fiyat = 39,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 104,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpoo6m1FBRp3_bGcjhQ09-jq5WYh8j3Jq_um25V4dB8xOrD94_x2FG1_EtrMWH0coSXIAM9N17W_Qfowua61MTtup7KyXBiuSc8pSGK2ECXxGs/300fx300f",
                },
                new Product
                {
                    Id = 26,
                    Name = "P250 | Nevermore (Factory New)",
                    Fiyat = 7,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 104,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpopujwezhh0szYI2gS09uklZaOk_7zNL7DhVRd4cJ5nqfF89qt2FHg_UdkNWymJI7AIQBraFqFrlK4kOu9jMW8ucycwSAwv3Ym-z-DyLzD5snZ/300fx300f",
                },
                new Product
                {
                    Id = 27,
                    Name = "Five-SeveN | Monkey Business (Field-Tested)",
                    Fiyat = 14,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 104,
                    URL= "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposLOzLhRlxfbGTj5X09q_goWYkuHxPYTTl2VQ5sROh-zF_Jn4xlbkqURvZmiidYKRdAFoNVzR81bryLvmjZ7o6ZjAmyYw7CNw7SmLzRepwUYbn3RWfTI/300fx300f",
                },
                new Product
                {
                    Id = 28,
                    Name = "Five-SeveN | Angry Mob (Field-Tested)",
                    Fiyat = 26,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 104,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposLOzLhRlxfbGTj5X09q_goW0hPLiNrXul2VW-txOh-zF_Jn4xgbj_EVpNjumIoXDJgZvMAyErgK7lLzph8K478mdmHBmu3R24n-OnBepwUYbC2gdqm4/300fx300f",
                },
                new Product
                {
                    Id = 29,
                    Name = "Desert Eagle | Code Red (Well-Worn)",
                    Fiyat = 117,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 104,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposr-kLAtl7PTbTjlH7du6kb-KkPDmNqjCmXlu5cB1g_zMu92ljFDj-kZsYzugI4OcegA_YwvS8gS7wby9g8fvvMjJznRm7yYnt3jD30vgHEZjJVE/300fx300f",
                },
                new Product
                {
                    Id = 30,
                    Name = "USP-S | Kill Confirmed (Minimal Wear)",
                    Fiyat = 476,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 104,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpoo6m1FBRp3_bGcjhQ09-jq5WYh8j_OrfdqWhe5sN4mOTE8bP5gVO8v109YDj0do7Dcw9taA6C81K_k-_n1pfp6MnOnSZhu3Qm4SrfzBbkg01McKUx0iC2I2fd/300fx300f",
                },
                new Product
                {
                    Id = 31,
                    Name = "MP5-SD | Phosphor (Field-Tested)",
                    Fiyat = 23,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou6rwOANf1OD3fC0X09qzh5SCgfb4DL_Dn3tu5cB1g_zMu9n33waw-hZqMmvxLNLAJwBqYViDrFO8yObugZ_vtZmcyHcw7HYm5CrD30vg0FG2818/300fx300f",
                },
                new Product
                {
                    Id = 32,
                    Name = "P90 | Asiimov (Field-Tested)",
                    Fiyat = 53,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpopuP1FAR17OORIXBD_9W_mY-dqPrxN7LEmyUF7MEniOqXpY2hiwbs80s-Zjv1Jo-QcQM8NF_Z81Ltxr3qgJ_tuc6b1zI97XT1Ujq3/300fx300f",
                },
                new Product
                {
                    Id = 33,
                    Name = "MAC-10 | Stalker (Well-Worn)",
                    Fiyat = 59,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou7umeldf1OD3fDxBvYyJh5SKm_zxIYTck29Y_cg_3e_FrNWkigTgrkM_Zmn7IIGXc1M7Yl_X_lPvx-zrhpC_tM7OwCNl6T5iuyiXe4lf6Q/300fx300f",
                },
                new Product
                {
                    Id = 34,
                    Name = "MAC-10 | Neon Rider (Factory New)",
                    Fiyat = 79,
                    Kaliteturu = EKaliteturu.factory_new,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou7umeldf0Ob3fDxBvYyJmoWEmeX9N77DqWdY781lxL3D9NSni1LmqRJuN2ClcNWTewJqZljXqFS4wurthMTu787LySBivSQ8pSGKiltL9Jg/300fx300f",
                },
                new Product
                {
                    Id = 35,
                    Name = "MP7 | Bloodsport (Minimal Wear)",
                    Fiyat = 35,
                    Kaliteturu = EKaliteturu.minimal_wear,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou6ryFABz7P7YJgJA4NO5kJObmOXgDLfYkWNFpsRz3-qSpdis2AW3rhFvYWn3LISSdgRsYVzR8lC7lOm9gMO_786bwHd9-n51Z2R5ZH4/300fx300f",
                },
                new Product
                {
                    Id = 36,
                    Name = "UMP-45 | Primal Saber (Field-Tested)",
                    Fiyat = 15,
                    Kaliteturu = EKaliteturu.field_tested,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpoo7e1f1Jf0Ob3ZDBSuImJhJKCmvb4ILrTk3lu5cB1g_zMu46jjAGy80c_ajqgd9OTdFRoZl_V_VG5xr_r1pO9vMvNyidhs3Rztn7D30vgvDNIovc/300fx300f",
                },
                new Product
                {
                    Id = 37,
                    Name = "MP7 | Powercore (Well-Worn)",
                    Fiyat = 3,
                    Kaliteturu = EKaliteturu.well_worn,
                    CategoryId = 103,
                    URL = "https://steamcommunity-a.akamaihd.net/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou6ryFABz7OPHZjhQ79Okkb-Gh6DLPr7Vn35cppwm37-S8Nn20VXmr0o-ajvwIYScIFRrZV-F_lK_xem-g5C4u5rOnXB9-n5169l_4VQ/300fx300f",
                }

            );
        }
    }
}