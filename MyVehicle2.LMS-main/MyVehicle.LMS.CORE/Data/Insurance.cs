using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }
        public string InsuranceType { get; set; }
        public double InsuranceValues { get; set; }

        public ICollection<LicensingAndInsurance> LicensingAndInsurances
        {

            get; set;
        }

    }
}
