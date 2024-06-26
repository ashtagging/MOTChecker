﻿namespace MOTChecker.Models
{
    public class MotDetails
    {
        public string CompletedDate { get; set; }

        public string TestResult { get; set; }

        public string ExpiryDate { get; set; }

        public string OdometerValue { get; set; }

        public string OdometerUnit { get; set; }

        public string MotTestNumber { get; set; }

        public List<FaultDetails>? rfrAndComments { get; set; }
    }
}
