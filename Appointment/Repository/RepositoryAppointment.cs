using Appointments.Models;

namespace Appointments.Repository
{
    public class RepositoryAppointment
    {
        private List<Appointment> appointments;

        public RepositoryAppointment(List<Appointment> appointments) 
        {
            this.appointments = appointments;
        }

        public List<Appointment> GetList()
        {
            return appointments;
        }

        public Appointment GetAppointment(int id)
        {
            return appointments[id];
        }

        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        public void RemoveAppointment(Appointment appointment)
        {
            appointments.Remove(appointment);
        }
        public bool ControlId(int id)
        {
            bool uniqueId = true;
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Id == id)
                {
                    uniqueId = false;
                }
            }
            return uniqueId;
        }
    }
}
