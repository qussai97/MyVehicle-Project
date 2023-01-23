using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.DTO
{
  public class VehicleSystemReport
    {


        //vehicleRepository
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleCategory { get; set; }
        public string UseType { get; set; }
        public string RegisterType { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiry { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }





    }
}
