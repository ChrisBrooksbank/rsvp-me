using Microsoft.EntityFrameworkCore;
using RSVPME.DataAccess.Entities;

namespace RSVPME.DataAccess
{
    public class RSVPMeContext: DbContext
    {
        public RSVPMeContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Event> Events { get; set; }
    }
}
