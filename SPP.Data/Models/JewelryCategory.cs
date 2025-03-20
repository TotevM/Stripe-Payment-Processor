public class JewelryCategory
{
	public Guid JewelryId { get; set; }
	public Jewelry Jewelry { get; set; } = null!;

	public Guid CategoryId { get; set; }
	public Category Category { get; set; } = null!;
}
