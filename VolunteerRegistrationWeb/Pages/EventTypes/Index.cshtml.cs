using Microsoft.AspNetCore.Mvc.RazorPages;
using VolunteerRegistrationWeb.Data;
using VolunteerRegistrationWeb.Model;

namespace VolunteerRegistrationWeb.Pages.EventTypes
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public IEnumerable<EventType> EventTypes { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

            EventTypes = _context.EventType;

        }
    }
}
