using SPP.Data.Models;

public class Order
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? PaidAt { get; set; }
    public bool IsPaid { get; set; } = false;
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}

