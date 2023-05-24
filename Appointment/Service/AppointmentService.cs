using Appointments.Extra;
using Appointments.Interface;
using Appointments.Models;
using Appointments.Repository;

namespace Appointments.Service
{
    public class AppointmentService : IAppointmentService
    {
        private RepositoryAppointment repository;
        private readonly IdGenerator idGenerator;

        public AppointmentService(RepositoryAppointment repository, IdGenerator idGenerator) 
        {
            this.repository = repository;
            this.idGenerator = idGenerator;
        }
        public void DeleteAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException();
            }
            repository.RemoveAppointment(appointment);
        }

        public void AddAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException();
            }
            int rnd = idGenerator.GetId();
            bool uniqueId = repository.ControlId(rnd);
            while (!uniqueId)
            {
                rnd = idGenerator.GetId();
                uniqueId = repository.ControlId(rnd);
            }
            appointment.Id = rnd;
            repository.AddAppointment(appointment);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            var appointments = repository.GetList();
            if (appointments == null)
            {
                throw new ArgumentNullException();
            }
            return appointments;
        }

        public void UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
