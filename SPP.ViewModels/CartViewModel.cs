using System.ComponentModel.DataAnnotations;

namespace SPP.ViewModels
{
    public class CartViewModel
    {
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();
        public decimal Subtotal => Items.Sum(item => item.Price * item.Quantity);
        public decimal Tax => Subtotal * 0.20m; // 20% tax rate
        public decimal Total => Subtotal + Tax;
    }

    public class CartItemViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
} 