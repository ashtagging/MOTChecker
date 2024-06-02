using MOTChecker.Models;

namespace MOTChecker.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient _httpClient;

        public VehicleService(HttpClient httpClient)
        {
            _httpClient= httpClient;
        }

        public async Task<VehicleDetails> GetMotData(string registration)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration={registration.Replace(" ", "").ToUpper()}");

            request.Headers.Add("x-api-key", "fZi8YcjrZN1cGkQeZP7Uaa4rTxua8HovaswPuIno");

            try
            {
                var response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<VehicleDetails>>();

                    if (data != null && data.Count > 0)
                    {
                        return data[0];
                    }
                }
            }
            catch(Exception ex) 
            { 
                throw new Exception(ex.ToString()); 
            }

            return null;
        }
    }
}
