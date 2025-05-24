public class Product
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public decimal Price { get; set; }
	public string Material { get; set; } = null!;
    public string Type { get; set; } = null!;
	public string? ImageUrl { get; set; }
    public bool IsDeleted { get; set; } = false;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
