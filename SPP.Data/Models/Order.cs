using SPP.Data.Models;

public class Order
{
	public Guid Id { get; set; }
	public DateTime OrderDate { get; set; }
	public Guid UserId { get; set; }
	public ApplicationUser User { get; set; } = null!;

	public Guid PaymentId { get; set; }
	public Payment Payment { get; set; } = null!;

	// Navigation
	public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
