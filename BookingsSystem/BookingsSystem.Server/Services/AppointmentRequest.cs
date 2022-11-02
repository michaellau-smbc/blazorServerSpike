namespace BookingsSystem.Server.Services
{
    public class AppointmentRequest
    {
        public string AppointmentType { get; set; }
        public DateTime SelectedDate { get; set; }
        public int Consecutive { get; set; }
        public int Parallel { get; set; }
    }
}