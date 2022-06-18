using System.ComponentModel.DataAnnotations;

namespace VolunteerRegistrationWeb.Model
{
    public class EventType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EventTypeName { get; set; }
        public DateTime EventTypeCreatedDate { get; set; } = DateTime.Now;

    }
}
