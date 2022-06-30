using MeowMartOnline.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeowMartOnline.Api.Data
{
    public class MeowMartOnlineDbContext: DbContext
    {
        public MeowMartOnlineDbContext(DbContextOptions<MeowMartOnlineDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			//Products
			//Beauty Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Pet Grooming Kit",
				Description = "A regular pet grooming kit for your cat!",
				ImageURL = "/Images/Beauty/Beauty1.png",
				Price = 100,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Fur Brush Set",
				Description = "A fur brush set to keep your cats' fur neat and tidy!",
				ImageURL = "/Images/Beauty/Beauty2.png",
				Price = 50,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "FurBar Set",
				Description = "A kit provided by cat lovers!",
				ImageURL = "/Images/Beauty/Beauty3.png",
				Price = 20,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Fluff and Puff set",
				Description = "A kit provided by CatLark, ensures your cat's fluffiness!",
				ImageURL = "/Images/Beauty/Beauty4.png",
				Price = 50,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = " Meow Care Kit",
				Description = "Meow Care Kit, containing skin care and hair care products",
				ImageURL = "/Images/Beauty/Beauty5.png",
				Price = 30,
				Qty = 85,
				CategoryId = 1

			});
			//Electronics Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Cat Massager",
				Description = "a cat massager for cats",
				ImageURL = "/Images/Electronic/Electronics1.png",
				Price = 100,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Cat headphones",
				Description = "Decorative headphones for your cat!",
				ImageURL = "/Images/Electronic/Electronics2.png",
				Price = 40,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Black Cat Headphones",
				Description = "A different variant of headphones for your cat",
				ImageURL = "/Images/Electronic/Electronics3.png",
				Price = 40,
				Qty = 300,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "Digital Camera with Tripod",
				Description = "Take high quality pictures with your cat!",
				ImageURL = "/Images/Electronic/Electronic4.png",
				Price = 600,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Hi-Pixel Digital Camera",
				Description = "Digital camera to take more pictures of cats!",
				ImageURL = "/Images/Electronic/Electronic5.png",
				Price = 500,
				Qty = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Gameboy",
				Description = "Gameboy - Provided by CatTendo",
				ImageURL = "/Images/Electronic/technology6.png",
				Price = 100,
				Qty = 60,
				CategoryId = 3
			});
			//Furniture Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Cat Office Chair",
				Description = "A comfortable chair for your cat to rest!",
				ImageURL = "/Images/Furniture/Furniture1.png",
				Price = 50,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Pink Leather Office Chair",
				Description = "Very comfortable pink leather office chair",
				ImageURL = "/Images/Furniture/Furniture2.png",
				Price = 50,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "Lounge Chair",
				Description = "Very comfortable lounge chair for your cat!",
				ImageURL = "/Images/Furniture/Furniture3.png",
				Price = 70,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Silver Lounge Chair",
				Description = "Very comfortable Silver lounge chair",
				ImageURL = "/Images/Furniture/Furniture4.png",
				Price = 120,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Porcelain Table Lamp",
				Description = "White and blue Porcelain Table Lamp",
				ImageURL = "/Images/Furniture/Furniture6.png",
				Price = 15,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "Office Table Lamp",
				Description = "Office Table Lamp",
				ImageURL = "/Images/Furniture/Furniture7.png",
				Price = 20,
				Qty = 73,
				CategoryId = 2
			});
			//Shoes Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "Cat Sneakers",
				Description = "Decorative cat sneakers for your cat!",
				ImageURL = "/Images/Shoes/Shoes1.png",
				Price = 100,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "Colorful Cat Trainers",
				Description = "Colorful trainers for your cat to walk on!",
				ImageURL = "/Images/Shoes/Shoes2.png",
				Price = 150,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "Nike Cat Trainers",
				Description = "Nike Cat trainers for your cat",
				ImageURL = "/Images/Shoes/Shoes3.png",
				Price = 200,
				Qty = 70,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
				Name = "Colorful Hummel Trainers",
				Description = "Colorful Hummel Trainers for your cat",
				ImageURL = "/Images/Shoes/Shoes4.png",
				Price = 120,
				Qty = 120,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
				Name = "Red Cat Trainers",
				Description = "Red Cat Trainers for any cat lovers who love to run",
				ImageURL = "/Images/Shoes/Shoes5.png",
				Price = 200,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
				Name = "Cat Sandles",
				Description = "Cat lover sandles",
				ImageURL = "/Images/Shoes/Shoes6.png",
				Price = 50,
				Qty = 150,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Bob"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Beauty"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Furniture"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "Electronics"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Shoes"
			});
		}


		public DbSet<Cart> Carts { get; set; } 
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
