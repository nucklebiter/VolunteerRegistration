using VolunteerRegistrationWeb.Model;
using Microsoft.EntityFrameworkCore;

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
