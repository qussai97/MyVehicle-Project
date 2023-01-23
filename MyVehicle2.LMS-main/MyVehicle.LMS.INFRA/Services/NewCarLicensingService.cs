using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class NewCarLicensingService: INewCarLicensingService
    {
        private readonly INewCarLicensingRepository newCarLicensingRepository;
        public NewCarLicensingService(INewCarLicensingRepository newCarLicensingRepository)
        {
            this.newCarLicensingRepository = newCarLicensingRepository;
        }

        public IEnumerable<PaymentValue> InsertNewCarLicensing(NewCarLicensing newCarLicensing)
        {
            return newCarLicensingRepository.InsertNewCarLicensing(newCarLicensing);
        }
    }
}
