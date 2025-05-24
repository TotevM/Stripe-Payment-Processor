using Microsoft.AspNetCore.Identity;

namespace SPP.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
