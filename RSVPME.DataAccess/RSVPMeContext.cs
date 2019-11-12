using Microsoft.EntityFrameworkCore;
using RSVPME.Domain.Entities;

namespace RSVPME.DataAccess
{
    public class RSVPMeContext: DbContext
    {
        public RSVPMeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
