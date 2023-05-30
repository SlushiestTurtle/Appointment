using Appointments.Extra;
using Appointments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsTest
{
    public class AppointmentServiceTest
    {
        private List<Appointment> list = new List<Appointment>();
        

        public static IEnumerable<object[]> GetAppointments()
        {
            yield return new object[]
            {
                new Appointment { Id = 0, Title = "Meeting", Description = "With boss", BookDate = new DateTime(2023, 07, 15, 14, 30, 0), Priority = Appointments.Extra.Priority.Medium },
                new Appointment { Id = 1, Title = "Dentis", Description = "Fix teeth", BookDate = new DateTime(2023, 06, 02, 07, 30, 0), Priority = Appointments.Extra.Priority.High },
                new Appointment { Id = 2, Title = "Shopping", Description = "Shopping with mom", BookDate = new DateTime(2023, 05, 26, 16, 45, 0), Priority = Appointments.Extra.Priority.Medium }
            };
        }

        int GetId()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }

        public bool ControlId(int id)
        {
            bool uniqueId = true;
            foreach (Appointment appointment in list)
            {
                if (appointment.Id == id)
                {
                    uniqueId = false;
                }
            }
            return uniqueId;
        }

        [Theory]
        [MemberData(nameof(GetAppointments))]
        public void AddNewAppointmentToList(Appointment appointment)
        {
            list.Add(new Appointment { Id = 4, Title = "Shopping", Description = "Shopping with dad", BookDate = new DateTime(2023, 06, 26, 16, 45, 0), Priority = Appointments.Extra.Priority.Medium });
            
            if (appointment == null)
            {
                throw new ArgumentNullException();
            }
            int rnd = GetId();
            bool uniqueId = ControlId(rnd);
            while (!uniqueId)
            {
                rnd = GetId();
                uniqueId = ControlId(rnd);
            }
            appointment.Id = rnd;
            list.Add(appointment);

            Assert.Equal(4, list.Count);
        }
    }
}
