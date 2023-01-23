using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.DTO
{
   public class VehiclesUsersLicenseExpiry
    { 
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }   
        
        public string LicenseNumber { get; set; }
        public string VehicleCategory { get; set; }
        public DateTime LicenseExpiry { get; set; }
        public string FullName { get; set; }      
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
