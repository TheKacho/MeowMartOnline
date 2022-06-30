using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeowMartOnline.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beauty" },
                    { 2, "Furniture" },
                    { 3, "Electronics" },
                    { 4, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "A regular pet grooming kit for your cat!", "/Images/Beauty/Beauty1.png", "Pet Grooming Kit", 100m, 100 },
                    { 2, 1, "A fur brush set to keep your cats' fur neat and tidy!", "/Images/Beauty/Beauty2.png", "Fur Brush Set", 50m, 45 },
                    { 3, 1, "A kit provided by cat lovers!", "/Images/Beauty/Beauty3.png", "FurBar Set", 20m, 30 },
                    { 4, 1, "A kit provided by CatLark, ensures your cat's fluffiness!", "/Images/Beauty/Beauty4.png", "Fluff and Puff set", 50m, 60 },
                    { 5, 1, "Meow Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", " Meow Care Kit", 30m, 85 },
                    { 6, 3, "a cat massager for cats", "/Images/Electronic/Electronics1.png", "Cat Massager", 100m, 120 },
                    { 7, 3, "Decorative headphones for your cat!", "/Images/Electronic/Electronics2.png", "Cat headphones", 40m, 200 },
                    { 8, 3, "A different variant of headphones for your cat", "/Images/Electronic/Electronics3.png", "Black Cat Headphones", 40m, 300 },
                    { 9, 3, "Take high quality pictures with your cat!", "/Images/Electronic/Electronic4.png", "Digital Camera with Tripod", 600m, 20 },
                    { 10, 3, "Digital camera to take more pictures of cats!", "/Images/Electronic/Electronic5.png", "Hi-Pixel Digital Camera", 500m, 15 },
                    { 11, 3, "Gameboy - Provided by CatTendo", "/Images/Electronic/technology6.png", "Gameboy", 100m, 60 },
                    { 12, 2, "A comfortable chair for your cat to rest!", "/Images/Furniture/Furniture1.png", "Cat Office Chair", 50m, 212 },
                    { 13, 2, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, 112 },
                    { 14, 2, "Very comfortable lounge chair for your cat!", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, 90 },
                    { 15, 2, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, 100 },
                    { 17, 2, "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, 73 },
                    { 18, 4, "Decorative cat sneakers for your cat!", "/Images/Shoes/Shoes1.png", "Cat Sneakers", 100m, 50 },
                    { 19, 4, "Colorful trainers for your cat to walk on!", "/Images/Shoes/Shoes2.png", "Colorful Cat Trainers", 150m, 60 },
                    { 20, 4, "Nike Cat trainers for your cat", "/Images/Shoes/Shoes3.png", "Nike Cat Trainers", 200m, 70 },
                    { 21, 4, "Colorful Hummel Trainers for your cat", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, 120 },
                    { 22, 4, "Red Cat Trainers for any cat lovers who love to run", "/Images/Shoes/Shoes5.png", "Red Cat Trainers", 200m, 100 },
                    { 23, 4, "Cat lover sandles", "/Images/Shoes/Shoes6.png", "Cat Sandles", 50m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
