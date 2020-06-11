using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TazedirektsonAPI.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Marka = table.Column<byte>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    PreviousCost = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    NumberInStock = table.Column<int>(nullable: false),
                    Info = table.Column<string>(nullable: false),
                    KargoFiyatı = table.Column<double>(nullable: false),
                    ToplamSiparisSayisi = table.Column<int>(nullable: false),
                    Tag = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    SepetId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    SepeteKonulmaTarihi = table.Column<DateTime>(nullable: false),
                    Adet = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.SepetId);
                    table.ForeignKey(
                        name: "FK_Sepet_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sepet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    SiparisId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SiparisTarihi = table.Column<DateTime>(nullable: false),
                    Adet = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.SiparisId);
                    table.ForeignKey(
                        name: "FK_Siparis_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparis_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "sebze meyve" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 101, "et urunleri" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 102, "sut ve sut urunleri" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 103, "kahvaltilik urunler" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 104, "temel gidalar" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 105, "atistirmaliklar" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 106, "unlu mamuller" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 107, "icecekler" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 108, "bebek cocuk urunleri" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 109, "ozel beslenme" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "UserName" },
                values: new object[] { 1, "batuhan4644@gmail.com", "Gorgel", "Batuhan", "1234", "GorgelBatuhan" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "UserName" },
                values: new object[] { 2, "Orkunzturk@gmail.com", "Öztürk", "Orkun", "4567", "OzturkOrkun" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 100, 101, 59.0, "Tazedirekt - Dana Yemeklik Kuşbaşı 500 g - Happy Village", 0.0, (byte)8, "5QS63EA", 15, 47.0, (byte)1, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/06013013/06013013-933eaf-221x148.jpg "});

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 118, 101, 197.0, "Orvital Dana Strogonof 500 g 'W10", 0.0, (byte)6, "Quru", 12, 10.0, (byte)2, 1, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/06013013/06013013-933eaf-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 117, 101, 29.0, "Sağdıçlar Balıkçılık Şiş Köfte 250 Mehmet Emin Sever Çiftliği", 0.0, (byte)9, "31.8029", 35, 25.0, (byte)3, 1, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28089142/28089142-d9d81c-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 116, 101, 6.0, "Sağdıçlar BalıkçılıkKuzu Sote 500 g-Şaban Amcanın Çiftliği", 0.0, (byte)6, "G315-4B75D256W161C", 8, 96.0, (byte)3, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/56010547/56010547-378b01-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 115, 101, 59.0, "Tazedirekt Kuzu Kaburga 500 g - W10", 0.0, (byte)4, "Gündoğdu", 50, 5700.0, (byte)3, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/56010645/56010645-2cdbfd-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 114, 101, 49.0, "TazedirektDilimli Yarı Pişmiş Kuzu Kokoreç 200 g -Tchibo", 0.0, (byte)8, "6TC05EA", 50, 45.0, (byte)2, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/24010230/24010230-1a26aa-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 113, 101, 59.0, "Sağdıçlar Balıkçılık-Kuzu Dilimli Külbastı 500 g - Frico", 0.0, (byte)8, "9QH75EA", 35, 50.0, (byte)2, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/12500008/12500008-30a76e-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 112, 101, 19.0, "Tazedirekt-Semizotu 1 Demet- W10", 0.0, (byte)8, "Mom's Natural Foods", 8, 19.0, (byte)3, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/12500008/12500008-30a76e-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 111, 101, 18.0, "Sağdıçlar Balıkçılık Semizotu (Pimpirim) 500 g''-Kombu Culture", 0.0, (byte)2, "Datça Murat Çiftliği", 2, 10.0, (byte)2, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27272016/27272016-d53579-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 119, 101, 96.0, "Tazedirekt Organik Armut 500 g'W10", 0.0, (byte)6, "Ayfer Kaur", 18, 9700.0, (byte)3, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/06013013/06013013-933eaf-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Info", "KargoFiyatı", "Marka", "Name", "NumberInStock", "PreviousCost", "Tag", "ToplamSiparisSayisi", "Url" },
                values: new object[] { 110, 101, 59.0, "Sağdıçlar Balıkçılık-Organik Erik 500 g- Datça Murat Çiftliği", 0.0, (byte)8, "5QS63EA", 11, 50.0, (byte)1, 0, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28089142/28089142-d9d81c-221x148.jpg" });

            

           

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 100, "Reyhan Erdoğan Çiftliği", 100, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/24010230/24010230-1a26aa-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 118, "Datça Murat Çiftliği", 118, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/56010650/56010650-cb3f8e-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 117, "Datça Murat Çiftliği1", 117, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5058314/05058314-7547cd-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 116, "Reyhan Erdoğan Çiftliği1", 116, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5058314/05058314-7547cd-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 115, "Datça Murat Çiftliği2", 115, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5051779/05051779-2591e8-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 114, "Muhteşem Çikolatalı", 114, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5058314/05058314-7547cd-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 113, "Reyhan Erdoğan Çiftliği4", 113, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5051781/05051781-a4e7ef-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 119, "Reyhan Erdoğan Çiftliği5", 119, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5058314/05058314-7547cd-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 111, "Muhteşem Çikolatalı2", 111, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5060041/05060041-2e7ba5-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 110, "Gurme212", 110, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5061249/05061249-6f60a6-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 112, "Tazedirekt", 112, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/05050275/05050275-f5f0ae-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 108, "Gurme2124", 108, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5061249/05061249-6f60a6-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 107, "Unabella", 107, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5059092/05059092-5188b7-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 106, "Muhteşem Çikolatalı3", 106, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/05110394/05110394-a1fbaa-221x148.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[] { 105, "Unabella2", 105, "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5061249/05061249-6f60a6-221x148.jpg" });

            

            migrationBuilder.InsertData(
                table: "Sepet",
                columns: new[] { "SepetId", "Adet", "ProductID", "SepeteKonulmaTarihi", "UserId" },
                values: new object[] { 1, 1, 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Sepet",
                columns: new[] { "SepetId", "Adet", "ProductID", "SepeteKonulmaTarihi", "UserId" },
                values: new object[] { 2, 1, 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Siparis",
                columns: new[] { "SiparisId", "Adet", "ProductID", "SiparisTarihi", "UserId" },
                values: new object[] { 1, 1, 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Siparis",
                columns: new[] { "SiparisId", "Adet", "ProductID", "SiparisTarihi", "UserId" },
                values: new object[] { 2, 1, 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_ProductID",
                table: "Sepet",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_UserId",
                table: "Sepet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_ProductID",
                table: "Siparis",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_UserId",
                table: "Siparis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Siparis");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
