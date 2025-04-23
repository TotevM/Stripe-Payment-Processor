using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Seed some basic jewelry products
        builder.Entity<Product>().HasData(
            new Product { Id = Guid.NewGuid(), Name = "Gold Necklace", Description = "24k gold", Price = 199.99m },
            new Product { Id = Guid.NewGuid(), Name = "Silver Ring", Description = "Sterling silver", Price = 49.99m },
            new Product { Id = Guid.NewGuid(), Name = "Diamond Earrings", Description = "Genuine diamonds", Price = 299.99m }
        );
    }
}
