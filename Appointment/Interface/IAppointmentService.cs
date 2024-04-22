using Appointments.Models;

namespace Appointments.Interface
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointment(int id);
        void AddAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
    }
}
