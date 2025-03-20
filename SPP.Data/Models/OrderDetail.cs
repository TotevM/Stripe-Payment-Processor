public class OrderDetail
{
	public Guid OrderId { get; set; }
	public Order Order { get; set; } = null!;

	public Guid JewelryId { get; set; }
	public Jewelry Jewelry { get; set; } = null!;

	public int Quantity { get; set; }
}
