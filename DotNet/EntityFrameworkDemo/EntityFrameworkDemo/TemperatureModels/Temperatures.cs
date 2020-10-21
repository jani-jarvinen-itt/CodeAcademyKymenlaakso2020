using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo.TemperatureModels
{
    public partial class Temperatures
    {
        public int TemperatureId { get; set; }
        public string SensorId { get; set; }
        public double? TemperatureValue { get; set; }
        public DateTime? ValueDate { get; set; }
    }
}
