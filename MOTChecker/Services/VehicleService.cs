using MOTChecker.Models;

namespace MOTChecker.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public VehicleService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<VehicleDetails> GetData(string registration)
        {
            var httpClient = _httpClientFactory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration={registration}");

            request.Headers.Add("x-api-key", "fZi8YcjrZN1cGkQeZP7Uaa4rTxua8HovaswPuIno");

            var response = await httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<VehicleDetails>>();

                if (data != null && data.Count > 0)
                {
                    return data[0];
                }
            }

            return null;
        }
    }
}
