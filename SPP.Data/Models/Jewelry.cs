public class Jewelry
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public decimal Price { get; set; }
	public MaterialType Material { get; set; }
	public JewelryType Type { get; set; }
	public string? ImageUrl { get; set; }
	public ICollection<JewelryCategory> JewelryCategories { get; set; } = new List<JewelryCategory>();
	public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
