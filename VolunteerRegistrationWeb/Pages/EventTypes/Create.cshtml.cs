using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VolunteerRegistrationWeb.Data;
using VolunteerRegistrationWeb.Model;

namespace VolunteerRegistrationWeb.Pages.EventTypes
{
    [BindProperties]
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public EventType EventType { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {

            var checkDup = _context.EventType.FirstOrDefault(u => u.EventTypeName == EventType.EventTypeName);

            if (checkDup != null)
            {
                ModelState.AddModelError("EventType.EventTypeName", "Event Type Already Exist");
            }

            if (ModelState.IsValid)
            {
                await _context.EventType.AddAsync(EventType);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            
            return Page();

        }
    }
}
