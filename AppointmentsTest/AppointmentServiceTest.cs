using Appointments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsTest
{
    public class AppointmentServiceTest
    {
        private readonly Appointment appointment1 = new Appointment() { Id = 45, Title = "Meeting", Description = "With boss", BookDate = new DateTime(2023, 07, 15, 14, 30, 0), Priority = Appointments.Extra.Priority.Medium };

        [Theory]
        [InlineData(appointment1)]
        public void AddNewAppointmentToList(Appointment appointment)
        {

        }
    }
}
