using MOTChecker.Models;

namespace MOTChecker.Services
{
    public interface IVehicleService
    {
        public Task<VehicleDetails> GetData(string registration);
    }
}
