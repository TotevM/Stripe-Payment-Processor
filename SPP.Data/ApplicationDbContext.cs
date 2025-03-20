using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;

namespace StripePaymentProcessor.Data;

public class ApplicationDbContext : IdentityDbContext
{
	public DbSet<Jewelry> Jewelries { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<JewelryCategory> JewelryCategories { get; set; }
	public DbSet<ApplicationUser> AplicationUsers { get; set; }
	public DbSet<Payment> Payments { get; set; }
	public DbSet<Order> Orders { get; set; }
	public DbSet<OrderDetail> OrdersDetails { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<JewelryCategory>()
			.HasKey(jc => new { jc.JewelryId, jc.CategoryId });

		modelBuilder.Entity<JewelryCategory>()
			.HasOne(jc => jc.Jewelry)
			.WithMany(j => j.JewelryCategories)
			.HasForeignKey(jc => jc.JewelryId);

		modelBuilder.Entity<JewelryCategory>()
			.HasOne(jc => jc.Category)
			.WithMany(c => c.JewelryCategories)
			.HasForeignKey(jc => jc.CategoryId);

		// OrderDetail (Many-to-Many)
		modelBuilder.Entity<OrderDetail>()
			.HasKey(od => new { od.OrderId, od.JewelryId });

		modelBuilder.Entity<OrderDetail>()
			.HasOne(od => od.Order)
			.WithMany(o => o.OrderDetails)
			.HasForeignKey(od => od.OrderId);

		modelBuilder.Entity<OrderDetail>()
			.HasOne(od => od.Jewelry)
			.WithMany(j => j.OrderDetails)
			.HasForeignKey(od => od.JewelryId);

		// Order and Payment (One-to-One)
		modelBuilder.Entity<Order>()
			.HasOne(o => o.Payment)
			.WithOne(p => p.Order)
			.HasForeignKey<Order>(o => o.PaymentId);

		// Order and User (One-to-Many)
		modelBuilder.Entity<Order>()
			.HasOne(o => o.User)
			.WithMany(u => u.Orders)
			.HasForeignKey(o => o.UserId);

		SeedData(modelBuilder);
	}

	private void SeedData(ModelBuilder modelBuilder)
	{
		var ringCategoryId = Guid.NewGuid();
		var necklaceCategoryId = Guid.NewGuid();

		modelBuilder.Entity<Category>().HasData(
			new Category { Id = ringCategoryId, Name = "Rings" },
			new Category { Id = necklaceCategoryId, Name = "Necklaces" }
		);

		var jewelry1Id = Guid.NewGuid();
		var jewelry2Id = Guid.NewGuid();

		modelBuilder.Entity<Jewelry>().HasData(
			new Jewelry
			{
				Id = jewelry1Id,
				Name = "Gold Ring",
				Description = "A stunning gold ring with diamond accents.",
				Price = 299.99m,
				Material = MaterialType.Gold,
				Type = JewelryType.Ring,
				ImageUrl = "/images/gold_ring.jpg"
			},
			new Jewelry
			{
				Id = jewelry2Id,
				Name = "Silver Necklace",
				Description = "Elegant silver necklace with pearl pendant.",
				Price = 149.99m,
				Material = MaterialType.Silver,
				Type = JewelryType.Necklace,
				ImageUrl = "/images/silver_necklace.jpg"
			}
		);

		modelBuilder.Entity<JewelryCategory>().HasData(
			new JewelryCategory { JewelryId = jewelry1Id, CategoryId = ringCategoryId },
			new JewelryCategory { JewelryId = jewelry2Id, CategoryId = necklaceCategoryId }
		);
	}
}
