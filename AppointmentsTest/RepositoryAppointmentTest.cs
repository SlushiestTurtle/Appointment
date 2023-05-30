using Appointments.Models;
using Appointments.Extra;

namespace AppointmentsTest
{
    public class RepositoryAppointmentTest
    {
        [Fact]
        public void AddUniqueAppointmentToList()
        {
            List<Appointment> appointments = new List<Appointment>();

            appointments.Add(
                new Appointment 
                { 
                    Id = 1, 
                    Title = "Dentis", 
                    Description = "Fix teeth.", 
                    BookDate = DateTime.UtcNow, 
                    Priority = Priority.Medium 
                }
            );

            Assert.NotEmpty(appointments);
        }
        [Fact]
        public void RemoveUniqueAppointmentToList()
        {
            Appointment appointment = new Appointment
            {
                Id = 1,
                Title = "Dentis",
                Description = "Fix teeth.",
                BookDate = DateTime.UtcNow,
                Priority = Priority.Medium
            };
            List<Appointment> appointments = new List<Appointment>() { appointment };

            appointments.Remove(appointment);

            Assert.Empty(appointments);
        }
        [Fact]
        public void ControlId()
        {
            List<Appointment> appointments = new List<Appointment>() { 
                new Appointment { 
                    Id = 1, 
                    Title = "Dentis",
                    Description = "Fix teeth.", 
                    BookDate = DateTime.UtcNow, 
                    Priority = Priority.Medium 
                }
            };
            int id = GetId();

            bool uniqueId = true;
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Id == id)
                {
                    uniqueId = false;
                }
            }

            Assert.True(uniqueId);
        }
        int GetId()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }
    }
}