using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;


namespace SPP.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
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