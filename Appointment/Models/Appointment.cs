using Appointments.Extra;
using System.ComponentModel.DataAnnotations;

namespace Appointments.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime BookDate { get; set; }
        public Priority Priority { get; set; }
    }
}
