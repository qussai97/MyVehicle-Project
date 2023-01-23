using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class LicensingService: ILicensingService
    {
        private readonly ILicensingRepoisitory licensingRepoisitory;
        public LicensingService(ILicensingRepoisitory licensingRepoisitory)
        {
            this.licensingRepoisitory = licensingRepoisitory;
        }

        public List<Licensing> GetAllLicensing()
        {
            return licensingRepoisitory.GetAllLicensing();
        }

        public bool InsertLicensing(Licensing licensing)
        {
            return licensingRepoisitory.InsertLicensing(licensing);
        }

        public GetCost SearchInfo(EngineCapacityAndType capacityAndType)
        {
            return licensingRepoisitory.SearchInfo(capacityAndType);
        }

        public PaymentCost SearchLicensingCost(SearchLicensingCostByEngineCapasty searchLicensingCostByEngineCapasty)
        {
            return licensingRepoisitory.SearchLicensingCost(searchLicensingCostByEngineCapasty);
        }

        public bool UpdateLicensing(Licensing licensing)
        {
            return licensingRepoisitory.UpdateLicensing(licensing);
        }
    }
}
