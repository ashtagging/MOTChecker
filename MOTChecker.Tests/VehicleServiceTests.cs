using Moq;
using MOTChecker.Models;
using MOTChecker.Services;
using NUnit.Framework;
using RichardSzalay.MockHttp;

namespace MOTChecker.Tests
{
    [TestFixture]
    public class VehicleServiceTests
    {
        private Mock<HttpMessageHandler> _httpMessageHandlerMock;
        private HttpClient _httpClient;
        private VehicleService _vehicleService;

        [SetUp]
        public void SetUp()
        {
            _httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            _vehicleService = new VehicleService(_httpClient);
        }

        [Test]
        public async Task GetMotData_ReturnsVehicleDetails_WhenRegistrationIsValid()
        {
            // Arrange
            var registration = "HY09VLP";
            var http = new MockHttpMessageHandler();
            var expectedUrl = "https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration=HY09VLP";

            

            // Act
            var result = await _vehicleService.GetMotData(registration);

            // Assert

        }

        [Test]
        public async Task GetData_ReturnsNull_WhenRegistrationInvalid()
        {
            // Arrange
            var registration = "AB123CD";
            var expectedUrl = "https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration=AB123CD";

            // Act
            var result = await _vehicleService.GetMotData(registration);

            // Assert

        }
    }
}
