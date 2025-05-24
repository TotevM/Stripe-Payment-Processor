using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripePaymentProcessor.Data.Migrations
{
    /// <inheritdoc />
    public partial class finaliseddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ed2eed-9017-445e-b448-82185039b921"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b9f7e24-b8f7-465b-a26f-6884e9c9784d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ba76572-39e2-48d9-8b3f-bf961a3abcdc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("104b27e5-bd36-49c8-9bf6-07a39bf33cc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cd1bb50-4375-4e80-9bb9-5c6188410896"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b4d3789-c0e3-4068-9792-1795b0787026"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b5dc321-f383-4523-a133-acea3911b277"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8200661c-784f-4a31-b618-1d039b9278e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82b268b1-a61d-4ce3-a1c3-3073492c1f5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a874641e-0c98-4df0-aa88-fbbd48ff41d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba19bc7f-61bb-44b8-bdad-700f584d3406"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c47b2205-66da-44b8-8ded-3bb117600a46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2bd3f33-4dfd-4dab-8039-592f623e770d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8a30643-a7a4-4f9d-a921-52ebb39efa43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f051a6f0-4aef-45ad-9525-7483dc691dea"));

            migrationBuilder.DropColumn(
                name: "PriceAtPurchase",
                table: "OrderItems");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Material",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaidAt",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Material",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceAtPurchase",
                table: "OrderItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Material", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("01ed2eed-9017-445e-b448-82185039b921"), "Simple silver brooch perfect for any outfit.", "https://efsterling.com/cdn/shop/products/by2-st.jpg?v=1525401307", 1, "Silver Charm Brooch", 75.00m, 4 },
                    { new Guid("0b9f7e24-b8f7-465b-a26f-6884e9c9784d"), "18K gold pendant shaped like a delicate leaf.", "https://res.cloudinary.com/lbh-prod/image/fetch/w_1000,f_auto,q_auto/https://www.ross-simons.com/on/demandware.static/-/Sites-lbh-master/default/dw28ac017c/images/jewelry-gold-necklaces/953253.jpg", 0, "Golden Leaf Pendant", 149.95m, 4 },
                    { new Guid("0ba76572-39e2-48d9-8b3f-bf961a3abcdc"), "Graceful pearl bracelet with small charms.", "https://www.bibaandrose.co.uk/wp-content/uploads/2020/03/charm-br.jpg", 4, "Pearl Charm Bracelet", 112.30m, 2 },
                    { new Guid("104b27e5-bd36-49c8-9bf6-07a39bf33cc6"), "Diamond necklace with a teardrop-shaped pendant.", "https://elementbespokejewellery.com/cdn/shop/products/ElementBespokeJewelleryBirmingham_diamondnecklace_1_2048x2048.jpg?v=1611150359", 3, "Diamond Teardrop Necklace", 145.60m, 1 },
                    { new Guid("6cd1bb50-4375-4e80-9bb9-5c6188410896"), "Stylish diamond earrings with sparkling clarity.", "https://www.alighieri.com/cdn/shop/products/17_SALT_PEPPEREARRINGS_3.png?crop=center&height=1275&v=1676895899&width=1080", 3, "Diamond Spark Earrings", 120.75m, 3 },
                    { new Guid("7b4d3789-c0e3-4068-9792-1795b0787026"), "Elegant pearl drop earrings with a classic style.", "https://hamiltonandinches.com/media/catalog/product/cache/9181a0a2f38e4d88d07b3ff1853f6e95/0/0/00-25177.jpg", 4, "Pearl Drop Earrings", 89.20m, 3 },
                    { new Guid("7b5dc321-f383-4523-a133-acea3911b277"), "A timeless 18K gold ring with a minimalist design.", "https://pristinediam.com/cdn/shop/files/205-JBDHR023_d2c71aeb-7026-49e6-8a02-56ea425ea375.jpg?v=1713180188", 0, "Golden Elegance Ring", 249.99m, 0 },
                    { new Guid("8200661c-784f-4a31-b618-1d039b9278e7"), "Luxurious platinum necklace, perfect for formal occasions.", "https://prod-images.fashionphile.com/large/f251f548e9fece17727ed01b2a3f25ca/e817ed6237c197aa468a9dd8552aa0e0.jpg", 2, "Platinum Grace Necklace", 399.00m, 1 },
                    { new Guid("82b268b1-a61d-4ce3-a1c3-3073492c1f5f"), "Platinum brooch with a geometric circle design.", "https://dsfantiquejewelry.com/cdn/shop/files/J.E.Caldwell_Co.DiamondBrooch.jpg?v=1739836183&width=2048", 2, "Platinum Circle Brooch", 210.00m, 4 },
                    { new Guid("a874641e-0c98-4df0-aa88-fbbd48ff41d6"), "Classic platinum band ring with polished surface.", "https://www.auronia.co.uk/media/catalog/product/V/R/VR201-0.05-PT-950-default.jpg", 2, "Platinum Band Ring", 325.00m, 0 },
                    { new Guid("ba19bc7f-61bb-44b8-bdad-700f584d3406"), "Charming heart-shaped necklace in 14K gold.", "https://danielladraper.com/cdn/shop/files/babyheartnecklacegold2_1.jpg?v=1705493046&width=3200", 0, "Gold Heart Necklace", 185.75m, 1 },
                    { new Guid("c47b2205-66da-44b8-8ded-3bb117600a46"), "Delicate diamond bracelet featuring an infinity symbol.", "https://www.jared.com/productimages/processed/V-211665803_0_800.jpg?pristine=true", 3, "Diamond Infinity Bracelet", 130.45m, 2 },
                    { new Guid("d2bd3f33-4dfd-4dab-8039-592f623e770d"), "Elegant silver bracelet with intricate patterns.", "https://bycharlotte.com.au/cdn/shop/files/b111g18-silver-path-to-harmony-bracelet-silver-1_ae8ef8c3-0653-4b5f-beb1-a120ee267f11.jpg?v=1701840881", 1, "Silver Harmony Bracelet", 99.50m, 2 },
                    { new Guid("d8a30643-a7a4-4f9d-a921-52ebb39efa43"), "Sleek silver drop earrings for everyday elegance.", "https://www.jonrichard.com/images/simply-silver-sterling-silver-925-cubic-zirconia-wrapped-in-love-drop-earrings-p46628-58939_zoom.jpg", 1, "Silver Drop Earrings", 59.90m, 3 },
                    { new Guid("f051a6f0-4aef-45ad-9525-7483dc691dea"), "Elegant gold ring featuring a solitaire design.", "https://www.jared.com/productimages/processed/V-161321702_1_800.jpg?pristine=true", 0, "Gold Solitaire Ring", 275.99m, 0 }
                });
        }
    }
}
