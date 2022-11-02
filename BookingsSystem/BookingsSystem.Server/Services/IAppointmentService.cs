namespace BookingsSystem.Server.Services
{
    public interface IAppointmentService
    {
        Task<string> AddAppointment(AppointmentRequest request);
    }
}
