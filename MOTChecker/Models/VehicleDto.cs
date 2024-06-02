namespace MOTChecker.Models
{
    public class VehicleDto
    {
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

        public string MotExpiryDate { get; set; }

        public string LastMileage { get; set; }
    }
}
