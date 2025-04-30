using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripePaymentProcessor.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProperSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
