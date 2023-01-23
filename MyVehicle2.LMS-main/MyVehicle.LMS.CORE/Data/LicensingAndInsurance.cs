using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class LicensingAndInsurance
    {
        [Key]
        public int LicenseValueId { get; set; }
        public double Value { get; set; }
        public int LicensingId { get; set; }
        public int InsuranceId { get; set; }
        public int VehicleId { get; set; }

        [ForeignKey("LicensingId")]
        public virtual Licensing Licensing { get; set; }

        [ForeignKey("InsuranceId")]
        public virtual Insurance Insurance { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicles Vehicles { get; set; }

    }
}
