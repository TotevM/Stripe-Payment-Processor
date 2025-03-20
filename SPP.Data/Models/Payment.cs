using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP.Data.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PlanId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string StripeSessionId { get; set; }
        public virtual ApplicationUser User { get; set; }
		public Order Order { get; set; } = null!;
	}
}
