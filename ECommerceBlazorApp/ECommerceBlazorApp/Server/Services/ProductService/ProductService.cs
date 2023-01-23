﻿using ECommerceBlazorApp.Server.Services.CategoryService;
using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 3,
                    Title = "Star Wars Jedi Knight Dark Forces II",
                    Description = "Jedi Knight takes place in the year 5 ABY, one year after Return of the Jedi and four years after Dark Forces.",
                    Image = "./images/jedi-knight-cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.00m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Minecraft",
                    Description = "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.",
                    Image = "./images/minecraft-cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Street Fighter Anniversary Collection",
                    Description = "Bundle of two Street Fighter games: Hyper Street Fighter II, and Street Fighter III: 3rd Strike.",
                    Image = "./images/street-fighter.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Star Ocean: Till The End of Time",
                    Description = "An action role-playing game, the third main game in the Star Ocean series. The game was developed by tri-Ace and published by Square Enix for the PlayStation 2 console.",
                    Image = "./images/star-ocean-tteot.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Title = "Kingdom Hearts II",
                    Description = "The game is a sequel to Kingdom Hearts, and like the original game, combines characters and settings from Disney films with those of Square Enix's Final Fantasy series.",
                    Image = "./images/kingdom-hearts-2.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Gameboy Color",
                    Description = "Nintendo handheld gaming console.",
                    Image = "./images/gbc.jpg",
                    Price = 80.00m,
                    OriginalPrice = 110.00m
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "Nintendo gaming console.",
                    Image = "./images/snes.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Canon AE01",
                    Description = "Vintage Canon film camera.",
                    Image = "./images/canon-ae-1.jpg",
                    Price = 150.00m,
                    OriginalPrice = 200.00m
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 1,
                    Title = "Atomic Habits",
                    Description = "A book about minuscule changes to habits for big changes in your life.",
                    Image = "./images/atomic-habits.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 1,
                    Title = "The Sublte Art Of Not Giving a F*ck",
                    Description = "A book about minuscule changes to habits for big changes in your life.",
                    Image = "./images/the-subtle-art.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 1,
                    Title = "Marcus Aurelius: Meditations",
                    Description = "A series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.",
                    Image = "./images/meditations.jpg",
                    Price = 11.99m,
                    OriginalPrice = 19.99m
                }
            };

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            var category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }
    }
}