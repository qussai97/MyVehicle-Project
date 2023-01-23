using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.DTO
{
   public  class TechnecalReportJoinDto
    {
        public string FullName { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleCategory { get; set; }
        public string UseType { get; set; }
        public string RegisterType { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiry { get; set; }
        public int EngineCapacity { get; set; }
        public string EngineType { get; set; }
        public DateTime MadeYear { get; set; }
        public string LicensingCenter { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string Address { get; set; }
        public double Cost { get; set; }
        public string InsuranceType { get; set; }
        public double InsuranceValues { get; set; }
        public double Value { get; set; }


    }
}
