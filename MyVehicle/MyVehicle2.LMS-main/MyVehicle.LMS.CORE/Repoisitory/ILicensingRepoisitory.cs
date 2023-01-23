using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface ILicensingRepoisitory
    {

        public List<Licensing> GetAllLicensing();

        public bool InsertLicensing(Licensing licensing );
        public bool UpdateLicensing(Licensing licensing );

        public PaymentCost SearchLicensingCost(SearchLicensingCostByEngineCapasty searchLicensingCostByEngineCapasty);

        public GetCost SearchInfo(EngineCapacityAndType capacityAndType);

    }
}
