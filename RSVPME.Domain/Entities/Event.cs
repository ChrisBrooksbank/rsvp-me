using System;

namespace RSVPME.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public bool IsPublished { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan? Duration { get; set; }
        public byte[] Image { get; set; }
        public string Details { get; set; }
        public Location Location { get; set; }
        public string RSVPQuestion { get; set; }
        public int? MaxGuests { get; set; }
        public int? AllowGuests { get; set; }
        public DateTime? RSVPOpen { get; set; }
        public DateTime? RSVPClose { get; set; }
        public Fee Fee { get; set; }
        public string AdditionalRefundPolicy { get; set; }
        public RSVPList RSVPList { get; set; }
    }
}
