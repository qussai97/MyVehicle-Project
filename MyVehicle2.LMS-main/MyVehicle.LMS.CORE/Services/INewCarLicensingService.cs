using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
 public   interface INewCarLicensingService
    {
        public IEnumerable<PaymentValue> InsertNewCarLicensing(NewCarLicensing newCarLicensing);
    }
}
