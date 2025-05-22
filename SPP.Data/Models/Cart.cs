using SPP.Data.Models;

public class Cart
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? FinalizedAt { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}

