using RSVPME.Domain.Enums;

namespace RSVPME.Domain.Entities
{
    public class Fee
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
