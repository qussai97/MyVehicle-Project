using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
  public   interface INewCarLicensingRepository
    {
        public IEnumerable<PaymentValue> InsertNewCarLicensing(NewCarLicensing newCarLicensing);
    }
}
