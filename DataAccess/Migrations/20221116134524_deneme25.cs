using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class deneme25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(500)", maxLength: 500, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserClaim = table.Column<int>(type: "int", nullable: false),
                    RegisterTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(7788))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UnitCalorie = table.Column<double>(type: "float", nullable: false),
                    ProductTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(5302)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(5607))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeID",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealTypeID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(350)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 11, 16, 16, 45, 23, 791, DateTimeKind.Local).AddTicks(6516)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 11, 16, 16, 45, 23, 791, DateTimeKind.Local).AddTicks(7015))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meal_MealType_MealTypeID",
                        column: x => x.MealTypeID,
                        principalTable: "MealType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meal_User_UserName",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gram = table.Column<double>(type: "float", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealDetail_Meal_MealID",
                        column: x => x.MealID,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MealDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "MealType",
                columns: new[] { "Id", "TypeName" },
                values: new object[,]
                {
                    { 1, "Kahvaltı" },
                    { 2, "AraÖğün" },
                    { 3, "ÖğleYemeği" },
                    { 4, "AkşamYemeği" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "ProductTypeName" },
                values: new object[,]
                {
                    { 1, "Meat" },
                    { 2, "Fish" },
                    { 3, "Staple Food" },
                    { 4, "Vegetable" },
                    { 5, "Fruit" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ProductName", "ProductTypeID", "UnitCalorie" },
                values: new object[,]
                {
                    { 1, "Antrikot", 1, 1.21 },
                    { 2, "Biftek", 1, 2.4199999999999999 },
                    { 3, "Bonfile", 1, 1.3799999999999999 },
                    { 4, "Dana Kıyma", 1, 2.46 },
                    { 5, "Hindi Budu", 1, 2.0800000000000001 },
                    { 6, "Hindi Göğsü", 1, 1.3500000000000001 },
                    { 7, "Hindi Kanadı", 1, 2.21 },
                    { 8, "Kuzu Pirzola", 1, 2.7599999999999998 },
                    { 9, "Kuzu İncik", 1, 2.0099999999999998 },
                    { 10, "Sığır Eti", 1, 2.48 },
                    { 11, "Sığır Filetosu", 1, 2.1800000000000002 },
                    { 12, "Sığır Kaburgası", 1, 2.3799999999999999 },
                    { 13, "Tavuk But", 1, 1.74 },
                    { 14, "Tavuk Ciğeri", 1, 1.6699999999999999 },
                    { 15, "Tavuk Göğsü", 1, 1.72 },
                    { 16, "Tavuk Kanadı", 1, 2.6600000000000001 },
                    { 17, "Tavuk Taşlığı", 1, 1.46 },
                    { 18, "Tavuk Yağı", 1, 8.9800000000000004 },
                    { 19, "Ördek", 1, 3.3700000000000001 },
                    { 20, "Şinitzel", 1, 1.5600000000000001 },
                    { 21, "Alabalık", 2, 1.8999999999999999 },
                    { 22, "Havyar", 2, 2.6400000000000001 },
                    { 23, "Lüfer", 2, 1.5900000000000001 },
                    { 24, "Mezgit", 2, 0.90000000000000002 },
                    { 25, "Midye", 2, 1.72 },
                    { 26, "Ton Balığı", 2, 1.3200000000000001 },
                    { 27, "Uskumru", 2, 2.6200000000000001 },
                    { 28, "Çipura", 2, 1.3500000000000001 },
                    { 29, "Somon", 2, 2.0600000000000001 },
                    { 30, "Kalkan Balığı", 2, 1.22 },
                    { 31, "Cheddar Peyniri ", 3, 4.0300000000000002 },
                    { 32, "Hellim", 3, 3.21 },
                    { 33, "Kaşar Peyniri", 3, 3.3700000000000001 },
                    { 34, "Tulum Peyniri", 3, 3.6299999999999999 },
                    { 35, "Yumuşak Peynir", 3, 2.6800000000000002 },
                    { 36, "Bazlama", 3, 2.3999999999999999 },
                    { 37, "Beyaz Ekmek", 3, 2.3799999999999999 },
                    { 38, "Esmer Ekmek", 3, 2.5 },
                    { 39, "Hamburger Ekmeği", 3, 1.78 },
                    { 40, "Lavaş", 3, 2.6400000000000001 },
                    { 41, "Mısır Ekmeği", 3, 1.79 },
                    { 42, "Tam Buğday Ekmek", 3, 2.4700000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ProductName", "ProductTypeID", "UnitCalorie" },
                values: new object[,]
                {
                    { 43, "Zeytin Yağı", 3, 8.8399999999999999 },
                    { 44, "Yeşil Zeytin", 3, 1.1499999999999999 },
                    { 45, "Siyah Zeytin", 3, 1.1499999999999999 },
                    { 46, "Bal", 3, 3.04 },
                    { 47, "Erik Reçeli", 3, 2.5 },
                    { 48, "Fıstık Ezmesi", 3, 5.8899999999999997 },
                    { 49, "Kayısı Reçeli", 3, 2.5 },
                    { 50, "Yumurta", 3, 0.96999999999999997 },
                    { 51, "Bamya ", 4, 0.33000000000000002 },
                    { 52, "Bezelye", 4, 0.81000000000000005 },
                    { 53, "Biber", 4, 0.27000000000000002 },
                    { 54, "Domates", 4, 0.17999999999999999 },
                    { 55, "Havuç", 4, 0.40999999999999998 },
                    { 56, "Kırmızı Biber", 4, 0.26000000000000001 },
                    { 57, "Kabak", 4, 0.26000000000000001 },
                    { 58, "Lahana", 4, 0.25 },
                    { 59, "Mantar", 4, 0.22 },
                    { 60, "Mısır", 4, 3.6499999999999999 },
                    { 61, "Patates", 4, 0.77000000000000002 },
                    { 62, "Patlıcan", 4, 0.25 },
                    { 63, "Pırasa", 4, 0.60999999999999999 },
                    { 64, "Salatalık", 4, 1.49 },
                    { 65, "Soğan", 4, 0.40000000000000002 },
                    { 66, "Sarımsak", 4, 1.49 },
                    { 67, "Turp", 4, 0.28000000000000003 },
                    { 68, "Marul", 4, 0.22 },
                    { 69, "Roka", 4, 0.25 },
                    { 70, "Kara Lahana", 4, 0.32000000000000001 },
                    { 71, "Armut", 5, 0.56999999999999995 },
                    { 72, "Ayva", 5, 0.56999999999999995 },
                    { 73, "Elma", 5, 0.52000000000000002 },
                    { 74, "Erik", 5, 0.46000000000000002 },
                    { 75, "Hurma", 5, 2.8199999999999998 },
                    { 76, "İncir", 5, 0.73999999999999999 },
                    { 77, "Muz", 5, 0.89000000000000001 },
                    { 78, "Karpuz", 5, 0.29999999999999999 },
                    { 79, "Kayısı", 5, 0.47999999999999998 },
                    { 80, "Kiraz", 5, 0.5 },
                    { 81, "Kivi", 5, 0.60999999999999999 },
                    { 82, "Nar", 5, 0.82999999999999996 },
                    { 83, "Portakal", 5, 0.46999999999999997 },
                    { 84, "Çilek", 5, 0.32000000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ProductName", "ProductTypeID", "UnitCalorie" },
                values: new object[] { 85, "Üzüm", 5, 0.68999999999999995 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ProductName", "ProductTypeID", "UnitCalorie" },
                values: new object[] { 86, "Şeftali", 5, 0.39000000000000001 });

            migrationBuilder.CreateIndex(
                name: "IX_Meal_MealTypeID",
                table: "Meal",
                column: "MealTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Meal_UserName",
                table: "Meal",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetail_MealID",
                table: "MealDetail",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetail_ProductId",
                table: "MealDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeID",
                table: "Product",
                column: "ProductTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealDetail");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "MealType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
