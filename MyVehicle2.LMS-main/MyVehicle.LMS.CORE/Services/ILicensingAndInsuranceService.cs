using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public  interface ILicensingAndInsuranceService
    {
        public bool InsertLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);
        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);

        public List<LicensingAndInsurance> GetAllLicensingAndInsurance();

        public bool CreateLicensingAndInsurance(LicensingInsurance licensingInsurance);
    }
}
