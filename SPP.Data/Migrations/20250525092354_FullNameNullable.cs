using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripePaymentProcessor.Data.Migrations
{
    /// <inheritdoc />
    public partial class FullNameNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01124441-cfb0-4954-81bf-df2a09ab4036"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("067521e6-8ac8-48c6-be6e-35e441e0ca69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098fa80d-a4a7-4322-a883-ad607150869f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31d58407-3cb0-437f-b672-53bf42e38b9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ddabe8d-34c6-4553-b731-897100f8f1a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b0e97e9-3c7a-4d27-8447-3981cc8748fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cebc22e-3fba-4721-9f43-903fbec1de89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("949442e0-ea06-46c1-a5e5-8eb22b63d916"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98357c6c-eb1c-4d02-af1e-b1a0f175a3c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4338845-7cf6-4a74-ba40-f819abff2ba1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baaf9988-3c48-42c3-b5a3-6dde538f734b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4dbc76a-a5f6-484f-9221-7f271530d3b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5faa103-e02a-421e-ba51-7e476b3cbd15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db0bd18b-73ee-446b-830b-71af987ffb03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efbfb7c1-a785-4141-9237-59066f91b63e"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Material", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("0430a33a-6fb2-48ef-9c38-7c731896da6e"), "Delicate diamond bracelet featuring an infinity symbol.", "https://www.jared.com/productimages/processed/V-211665803_0_800.jpg?pristine=true", "Diamond", "Diamond Infinity Bracelet", 130.45m, "Bracelet" },
                    { new Guid("0f956796-9692-4925-b10b-2da9502c7d89"), "Simple silver brooch perfect for any outfit.", "https://efsterling.com/cdn/shop/products/by2-st.jpg?v=1525401307", "Silver", "Silver Charm Brooch", 75.00m, "Brooch" },
                    { new Guid("192ee277-3634-4f67-8f75-77b3221657a7"), "Diamond necklace with a teardrop-shaped pendant.", "https://elementbespokejewellery.com/cdn/shop/products/ElementBespokeJewelleryBirmingham_diamondnecklace_1_2048x2048.jpg?v=1611150359", "Diamond", "Diamond Teardrop Necklace", 145.60m, "Necklace" },
                    { new Guid("609b1dd8-056c-4ee9-96bd-097b40edae99"), "Elegant gold ring featuring a solitaire design.", "https://www.jared.com/productimages/processed/V-161321702_1_800.jpg?pristine=true", "Gold", "Gold Solitaire Ring", 275.99m, "Ring" },
                    { new Guid("655350e5-abe4-4171-b0d0-f2cbf8867e24"), "Graceful pearl bracelet with small charms.", "https://www.bibaandrose.co.uk/wp-content/uploads/2020/03/charm-br.jpg", "Pearl", "Pearl Charm Bracelet", 112.30m, "Bracelet" },
                    { new Guid("6ff5cfd8-3726-49eb-ad36-f1344c91046e"), "Platinum brooch with a geometric circle design.", "https://dsfantiquejewelry.com/cdn/shop/files/J.E.Caldwell_Co.DiamondBrooch.jpg?v=1739836183&width=2048", "Platinum", "Platinum Circle Brooch", 210.00m, "Brooch" },
                    { new Guid("8a31b3b7-5e05-4b88-b712-0677546fb130"), "Classic platinum band ring with polished surface.", "https://www.auronia.co.uk/media/catalog/product/V/R/VR201-0.05-PT-950-default.jpg", "Platinum", "Platinum Band Ring", 325.00m, "Ring" },
                    { new Guid("927dccbc-fa5a-4e1f-a4c2-471cd77f1895"), "Elegant silver bracelet with intricate patterns.", "https://bycharlotte.com.au/cdn/shop/files/b111g18-silver-path-to-harmony-bracelet-silver-1_ae8ef8c3-0653-4b5f-beb1-a120ee267f11.jpg?v=1701840881", "Silver", "Silver Harmony Bracelet", 99.50m, "Bracelet" },
                    { new Guid("93d99b4f-383f-415e-9967-7804ca9ca917"), "Charming heart-shaped necklace in 14K gold.", "https://danielladraper.com/cdn/shop/files/babyheartnecklacegold2_1.jpg?v=1705493046&width=3200", "Gold", "Gold Heart Necklace", 185.75m, "Necklace" },
                    { new Guid("942c2a28-0292-4f20-9378-47dd300407e7"), "18K gold pendant shaped like a delicate leaf.", "https://res.cloudinary.com/lbh-prod/image/fetch/w_1000,f_auto,q_auto/https://www.ross-simons.com/on/demandware.static/-/Sites-lbh-master/default/dw28ac017c/images/jewelry-gold-necklaces/953253.jpg", "Gold", "Golden Leaf Pendant", 149.95m, "Brooch" },
                    { new Guid("b52b8031-29f0-4097-a295-4e02f13fbd53"), "Elegant pearl drop earrings with a classic style.", "https://hamiltonandinches.com/media/catalog/product/cache/9181a0a2f38e4d88d07b3ff1853f6e95/0/0/00-25177.jpg", "Pearl", "Pearl Drop Earrings", 89.20m, "Earring" },
                    { new Guid("ba798b51-30df-4017-9a07-f4cea409d79e"), "Luxurious platinum necklace, perfect for formal occasions.", "https://prod-images.fashionphile.com/large/f251f548e9fece17727ed01b2a3f25ca/e817ed6237c197aa468a9dd8552aa0e0.jpg", "Platinum", "Platinum Grace Necklace", 399.00m, "Necklace" },
                    { new Guid("be8c019f-3781-4a65-9239-f0c37f2b6fc6"), "Stylish diamond earrings with sparkling clarity.", "https://www.alighieri.com/cdn/shop/products/17_SALT_PEPPEREARRINGS_3.png?crop=center&height=1275&v=1676895899&width=1080", "Diamond", "Diamond Spark Earrings", 120.75m, "Earring" },
                    { new Guid("ce18312b-e8d3-4e1c-9193-6ce0e55314d5"), "Sleek silver drop earrings for everyday elegance.", "https://www.jonrichard.com/images/simply-silver-sterling-silver-925-cubic-zirconia-wrapped-in-love-drop-earrings-p46628-58939_zoom.jpg", "Silver", "Silver Drop Earrings", 59.90m, "Earring" },
                    { new Guid("dbd8ff33-2fc8-4964-948c-84e23ba562c4"), "A timeless 18K gold ring with a minimalist design.", "https://pristinediam.com/cdn/shop/files/205-JBDHR023_d2c71aeb-7026-49e6-8a02-56ea425ea375.jpg?v=1713180188", "Gold", "Golden Elegance Ring", 249.99m, "Ring" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0430a33a-6fb2-48ef-9c38-7c731896da6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f956796-9692-4925-b10b-2da9502c7d89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("192ee277-3634-4f67-8f75-77b3221657a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("609b1dd8-056c-4ee9-96bd-097b40edae99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("655350e5-abe4-4171-b0d0-f2cbf8867e24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ff5cfd8-3726-49eb-ad36-f1344c91046e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a31b3b7-5e05-4b88-b712-0677546fb130"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("927dccbc-fa5a-4e1f-a4c2-471cd77f1895"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93d99b4f-383f-415e-9967-7804ca9ca917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("942c2a28-0292-4f20-9378-47dd300407e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52b8031-29f0-4097-a295-4e02f13fbd53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba798b51-30df-4017-9a07-f4cea409d79e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be8c019f-3781-4a65-9239-f0c37f2b6fc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce18312b-e8d3-4e1c-9193-6ce0e55314d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbd8ff33-2fc8-4964-948c-84e23ba562c4"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Material", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("01124441-cfb0-4954-81bf-df2a09ab4036"), "Sleek silver drop earrings for everyday elegance.", "https://www.jonrichard.com/images/simply-silver-sterling-silver-925-cubic-zirconia-wrapped-in-love-drop-earrings-p46628-58939_zoom.jpg", "Silver", "Silver Drop Earrings", 59.90m, "Earring" },
                    { new Guid("067521e6-8ac8-48c6-be6e-35e441e0ca69"), "18K gold pendant shaped like a delicate leaf.", "https://res.cloudinary.com/lbh-prod/image/fetch/w_1000,f_auto,q_auto/https://www.ross-simons.com/on/demandware.static/-/Sites-lbh-master/default/dw28ac017c/images/jewelry-gold-necklaces/953253.jpg", "Gold", "Golden Leaf Pendant", 149.95m, "Brooch" },
                    { new Guid("098fa80d-a4a7-4322-a883-ad607150869f"), "Graceful pearl bracelet with small charms.", "https://www.bibaandrose.co.uk/wp-content/uploads/2020/03/charm-br.jpg", "Pearl", "Pearl Charm Bracelet", 112.30m, "Bracelet" },
                    { new Guid("31d58407-3cb0-437f-b672-53bf42e38b9e"), "Elegant gold ring featuring a solitaire design.", "https://www.jared.com/productimages/processed/V-161321702_1_800.jpg?pristine=true", "Gold", "Gold Solitaire Ring", 275.99m, "Ring" },
                    { new Guid("7ddabe8d-34c6-4553-b731-897100f8f1a5"), "Diamond necklace with a teardrop-shaped pendant.", "https://elementbespokejewellery.com/cdn/shop/products/ElementBespokeJewelleryBirmingham_diamondnecklace_1_2048x2048.jpg?v=1611150359", "Diamond", "Diamond Teardrop Necklace", 145.60m, "Necklace" },
                    { new Guid("8b0e97e9-3c7a-4d27-8447-3981cc8748fd"), "Platinum brooch with a geometric circle design.", "https://dsfantiquejewelry.com/cdn/shop/files/J.E.Caldwell_Co.DiamondBrooch.jpg?v=1739836183&width=2048", "Platinum", "Platinum Circle Brooch", 210.00m, "Brooch" },
                    { new Guid("8cebc22e-3fba-4721-9f43-903fbec1de89"), "Elegant silver bracelet with intricate patterns.", "https://bycharlotte.com.au/cdn/shop/files/b111g18-silver-path-to-harmony-bracelet-silver-1_ae8ef8c3-0653-4b5f-beb1-a120ee267f11.jpg?v=1701840881", "Silver", "Silver Harmony Bracelet", 99.50m, "Bracelet" },
                    { new Guid("949442e0-ea06-46c1-a5e5-8eb22b63d916"), "Classic platinum band ring with polished surface.", "https://www.auronia.co.uk/media/catalog/product/V/R/VR201-0.05-PT-950-default.jpg", "Platinum", "Platinum Band Ring", 325.00m, "Ring" },
                    { new Guid("98357c6c-eb1c-4d02-af1e-b1a0f175a3c3"), "Luxurious platinum necklace, perfect for formal occasions.", "https://prod-images.fashionphile.com/large/f251f548e9fece17727ed01b2a3f25ca/e817ed6237c197aa468a9dd8552aa0e0.jpg", "Platinum", "Platinum Grace Necklace", 399.00m, "Necklace" },
                    { new Guid("a4338845-7cf6-4a74-ba40-f819abff2ba1"), "Simple silver brooch perfect for any outfit.", "https://efsterling.com/cdn/shop/products/by2-st.jpg?v=1525401307", "Silver", "Silver Charm Brooch", 75.00m, "Brooch" },
                    { new Guid("baaf9988-3c48-42c3-b5a3-6dde538f734b"), "Delicate diamond bracelet featuring an infinity symbol.", "https://www.jared.com/productimages/processed/V-211665803_0_800.jpg?pristine=true", "Diamond", "Diamond Infinity Bracelet", 130.45m, "Bracelet" },
                    { new Guid("d4dbc76a-a5f6-484f-9221-7f271530d3b2"), "Stylish diamond earrings with sparkling clarity.", "https://www.alighieri.com/cdn/shop/products/17_SALT_PEPPEREARRINGS_3.png?crop=center&height=1275&v=1676895899&width=1080", "Diamond", "Diamond Spark Earrings", 120.75m, "Earring" },
                    { new Guid("d5faa103-e02a-421e-ba51-7e476b3cbd15"), "Elegant pearl drop earrings with a classic style.", "https://hamiltonandinches.com/media/catalog/product/cache/9181a0a2f38e4d88d07b3ff1853f6e95/0/0/00-25177.jpg", "Pearl", "Pearl Drop Earrings", 89.20m, "Earring" },
                    { new Guid("db0bd18b-73ee-446b-830b-71af987ffb03"), "A timeless 18K gold ring with a minimalist design.", "https://pristinediam.com/cdn/shop/files/205-JBDHR023_d2c71aeb-7026-49e6-8a02-56ea425ea375.jpg?v=1713180188", "Gold", "Golden Elegance Ring", 249.99m, "Ring" },
                    { new Guid("efbfb7c1-a785-4141-9237-59066f91b63e"), "Charming heart-shaped necklace in 14K gold.", "https://danielladraper.com/cdn/shop/files/babyheartnecklacegold2_1.jpg?v=1705493046&width=3200", "Gold", "Gold Heart Necklace", 185.75m, "Necklace" }
                });
        }
    }
}
