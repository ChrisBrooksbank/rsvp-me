using RSVPME.Domain.Enums;

namespace RSVPME.Domain.Entities
{
    public class RSVP
    {
        public User User { get; set; }
        public Event Event { get; set; }
        public RSVPResponse Response { get; set; }
    }
}
