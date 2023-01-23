using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Vehicles
    {
        [Key]
        public int VehicleId { get; set; }
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
        public string VehicleImage { get; set; }
        public int UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }

        public ICollection<LicensingAndInsurance> LicensingAndInsurance { get; set; }

    }
}
