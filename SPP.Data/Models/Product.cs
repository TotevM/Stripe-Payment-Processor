public class Product
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public decimal Price { get; set; }
	public MaterialType Material { get; set; }
	public JewelryType Type { get; set; }
	public string? ImageUrl { get; set; }
	public ICollection<OrderItem> OrderDetails { get; set; } = new List<OrderItem>();
}
