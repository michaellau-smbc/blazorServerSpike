using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace BookingsSystem.Server.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly HttpClient httpClient;

        public AppointmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;           
        }

        public async Task<string> AddAppointment(AppointmentRequest request)
        {
            var jsonData = JsonSerializer.Serialize(request);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Token", "TestToken");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "TestToken");
            var response = await httpClient.PostAsync("api/v1/Appointment", stringContent);

            if (response.IsSuccessStatusCode)
            {
                return "worked";
            }
            return "failed";
        }
    }
}
