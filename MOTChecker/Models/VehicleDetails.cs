﻿namespace MOTChecker.Models
{
    public class VehicleDetails
    {
        public string Registration { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string FirstUsedDate { get; set; }

        public string FuelType { get; set; }

        public string PrimaryColour { get; set; }

        public MotDetails[] MotTests { get; set; }
    }
}
