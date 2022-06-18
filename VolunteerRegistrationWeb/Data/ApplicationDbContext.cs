using Microsoft.EntityFrameworkCore;
using VolunteerRegistrationWeb.Model;

namespace VolunteerRegistrationWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<EventType> EventType { get; set; }

    }
}
