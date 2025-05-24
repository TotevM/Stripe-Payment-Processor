using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;


namespace SPP.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Type)
                .HasMaxLength(50);

            builder.Property(p => p.Material)
                .HasMaxLength(50);

            builder.Property(p => p.ImageUrl)
                .HasMaxLength(2048);

            builder.Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "SPP.Data", "Datasets", "products.json");
            string data = File.ReadAllText(path);
            var products = JsonSerializer.Deserialize<List<Product>>(data)!;

            foreach (var product in products)
            {
                product.Id = Guid.NewGuid();
            }

            if (products != null)
            {
                builder
                    .HasData(products);
            }
        }
    }
}