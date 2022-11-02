using BookingsSystem.Server.Services;
using Microsoft.AspNetCore.Components;

namespace BookingsSystem.Server.Pages
{
    public class AddAppointmentBase : ComponentBase
    {
        public AppointmentRequest Appointment { get; set; } = new AppointmentRequest();

        [Inject]
        public IAppointmentService AppointmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
        }

        protected async Task HandleValidSubmit()
        {
            var result = await AppointmentService.AddAppointment(Appointment);
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
