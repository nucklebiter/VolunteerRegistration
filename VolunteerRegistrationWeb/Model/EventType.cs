using System.ComponentModel.DataAnnotations;

namespace VolunteerRegistrationWeb.Model
{
    public class EventType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Event Type Name")]
        public string EventTypeName { get; set; }
        [Display(Name = "Event Type Created Date")]
        public DateTime EventTypeCreatedDate { get; set; } = DateTime.Now;

    }
}
