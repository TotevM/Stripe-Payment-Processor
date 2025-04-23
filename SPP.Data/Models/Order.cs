using SPP.Data.Models;

public class Order
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}

