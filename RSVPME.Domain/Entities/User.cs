using System.Collections.Generic;

namespace RSVPME.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string  Name { get; set; }
        public Location Location { get; set; }
        public List<byte[]> Photos { get; set; }
    }
}
