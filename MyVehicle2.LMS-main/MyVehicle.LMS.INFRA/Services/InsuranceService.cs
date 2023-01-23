using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class InsuranceService: IInsuranceService
    {
        private readonly IInsuranceRepoisitory insuranceRepoisitory ;
        public InsuranceService(IInsuranceRepoisitory insuranceRepoisitory)
        {
            this.insuranceRepoisitory = insuranceRepoisitory;
        }

        public List<Insurance> GetAllInsurance()
        {
            return insuranceRepoisitory.GetAllInsurance();
        }

        public bool InsertInsurance(Insurance insurance)
        {
            return insuranceRepoisitory.InsertInsurance(insurance);
        }

        public bool UpdateInsurance(Insurance insurance)
        {
            return insuranceRepoisitory.UpdateInsurance(insurance);
        }
    }
}
