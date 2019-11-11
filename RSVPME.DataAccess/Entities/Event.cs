using System;

namespace RSVPME.DataAccess.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string RSVPQuestion { get; set; }
        public int? AttendeeLimit { get; set; }
        public int? AllowGuests { get; set; }
        public DateTime? RSVPOpen { get; set; }
        public DateTime? RSVPClose { get; set; }
        public Boolean HasFee { get; set; }
        public string FeePaymentMethod { get; set; }
        public string FeeCurrency { get; set; }
        public decimal FeeAmount { get; set; }
        public string AdditionalRefundPolicy { get; set; }

    }
}
