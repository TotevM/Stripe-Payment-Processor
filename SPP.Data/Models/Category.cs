public class Category
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;

	// Navigation
	public ICollection<JewelryCategory> JewelryCategories { get; set; } = new List<JewelryCategory>();
}
