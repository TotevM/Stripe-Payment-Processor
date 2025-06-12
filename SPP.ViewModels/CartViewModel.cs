using static SPP.Common.AppConstants;
namespace SPP.ViewModels
{
    public class CartViewModel
    {
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();
        public decimal Subtotal => Items.Sum(item => item.Price * item.Quantity);
        public decimal Tax => Math.Round(Subtotal * TaxRate/100, 2);
        public decimal Total => Subtotal + Tax;
    }

    public class CartItemViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        //public decimal TotalPrice => Price * (1+TaxRate / 100);
        public int Quantity { get; set; }
    }
} 