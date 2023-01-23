using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Licensing
    {
        [Key]
        public int LicensingId { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string EngineType { get; set; }
        public int NumberPassengers { get; set; }
        public double Cost { get; set; }

        public ICollection<LicensingAndInsurance> LicensingAndInsurances
        { get; set; }
    }
}
