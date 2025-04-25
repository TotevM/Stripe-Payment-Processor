using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripePaymentProcessor.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d9a6d11-3693-4d9e-8e8f-6f1a00bb7e8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be05de35-c60c-4260-a54a-136246326836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa672e15-a54f-473f-94ae-6a8f41a2e6c7"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Material", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("3c611853-5bea-4269-93be-073b67b83dd0"), "A timeless 18K gold ring with a minimalist design.", "https://example.com/images/golden-ring.jpg", 0, "Golden Elegance Ring", 249.99m, 0 },
                    { new Guid("3f167925-63b6-4b83-832b-f2051f08487e"), "18K gold pendant shaped like a delicate leaf.", "https://example.com/images/golden-pendant.jpg", 0, "Golden Leaf Pendant", 149.95m, 4 },
                    { new Guid("5068ae55-01dd-4ce0-80c3-278252d00067"), "Stylish rose gold earrings with sparkling stones.", "https://example.com/images/rose-earrings.jpg", 3, "Rose Gold Spark Earrings", 120.75m, 3 },
                    { new Guid("51a58c89-25b1-4d9f-91a6-425590f12d44"), "Platinum pendant with a geometric circle design.", "https://example.com/images/platinum-pendant.jpg", 2, "Platinum Circle Pendant", 210.00m, 4 },
                    { new Guid("553d90cc-78c8-454e-85aa-821ed9f9df02"), "Charming heart-shaped necklace in 14K gold.", "https://example.com/images/gold-heart-necklace.jpg", 0, "Gold Heart Necklace", 185.75m, 1 },
                    { new Guid("60a1c80f-2fbf-4825-ab6b-10f531975c6e"), "Sleek silver drop earrings for everyday elegance.", "https://example.com/images/silver-earrings.jpg", 1, "Silver Drop Earrings", 59.90m, 3 },
                    { new Guid("6ec6da8b-dba6-469c-8c31-f392869e0df7"), "Elegant silver bracelet with intricate patterns.", "https://example.com/images/silver-bracelet.jpg", 1, "Silver Harmony Bracelet", 99.50m, 2 },
                    { new Guid("87bd64c0-cf78-42a0-aaa9-73a3967c3b5b"), "Luxurious platinum necklace, perfect for formal occasions.", "https://example.com/images/platinum-necklace.jpg", 2, "Platinum Grace Necklace", 399.00m, 1 },
                    { new Guid("aa40809c-2f75-4f72-a987-36f8c71de270"), "Modern titanium ring designed for durability and style.", "https://example.com/images/titanium-ring.jpg", 4, "Titanium Edge Ring", 89.99m, 0 },
                    { new Guid("ac4b5783-865e-44da-8f87-51343e6367d1"), "Classic platinum band ring with polished surface.", "https://example.com/images/platinum-band.jpg", 2, "Platinum Band Ring", 325.00m, 0 },
                    { new Guid("beba5cec-a336-4b19-9818-5de772525a9c"), "Delicate rose gold bracelet featuring an infinity symbol.", "https://example.com/images/rose-bracelet.jpg", 3, "Rose Gold Infinity Bracelet", 130.45m, 2 },
                    { new Guid("d5e99643-16bb-4a5f-9dec-65a364cda951"), "Rose gold necklace with teardrop-shaped pendant.", "https://example.com/images/rose-necklace.jpg", 3, "Rose Gold Teardrop Necklace", 145.60m, 1 },
                    { new Guid("d771781d-79f0-48af-85f4-ff58e51d5c33"), "Minimalist titanium stud earrings for daily wear.", "https://example.com/images/titanium-earrings.jpg", 4, "Titanium Stud Earrings", 70.20m, 3 },
                    { new Guid("e8ec0854-b2bb-4ed3-890d-93d52bc186c9"), "Simple silver pendant perfect for any chain.", "https://example.com/images/silver-charm.jpg", 1, "Silver Charm Pendant", 75.00m, 4 },
                    { new Guid("f3c4138e-def5-4d93-8020-d9da93f875e8"), "Contemporary titanium cuff bracelet with matte finish.", "https://example.com/images/titanium-bracelet.jpg", 4, "Titanium Cuff Bracelet", 110.00m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c611853-5bea-4269-93be-073b67b83dd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f167925-63b6-4b83-832b-f2051f08487e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5068ae55-01dd-4ce0-80c3-278252d00067"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51a58c89-25b1-4d9f-91a6-425590f12d44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("553d90cc-78c8-454e-85aa-821ed9f9df02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60a1c80f-2fbf-4825-ab6b-10f531975c6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec6da8b-dba6-469c-8c31-f392869e0df7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87bd64c0-cf78-42a0-aaa9-73a3967c3b5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa40809c-2f75-4f72-a987-36f8c71de270"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac4b5783-865e-44da-8f87-51343e6367d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("beba5cec-a336-4b19-9818-5de772525a9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e99643-16bb-4a5f-9dec-65a364cda951"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d771781d-79f0-48af-85f4-ff58e51d5c33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8ec0854-b2bb-4ed3-890d-93d52bc186c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3c4138e-def5-4d93-8020-d9da93f875e8"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Material", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("0d9a6d11-3693-4d9e-8e8f-6f1a00bb7e8a"), "Genuine diamonds", null, 0, "Diamond Earrings", 299.99m, 0 },
                    { new Guid("be05de35-c60c-4260-a54a-136246326836"), "Sterling silver", null, 0, "Silver Ring", 49.99m, 0 },
                    { new Guid("fa672e15-a54f-473f-94ae-6a8f41a2e6c7"), "24k gold", null, 0, "Gold Necklace", 199.99m, 0 }
                });
        }
    }
}
