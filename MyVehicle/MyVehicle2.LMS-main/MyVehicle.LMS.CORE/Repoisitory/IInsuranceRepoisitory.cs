using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
    public interface IInsuranceRepoisitory
    {
        public List<Insurance> GetAllInsurance();

        public bool InsertInsurance(Insurance insurance );
        public bool UpdateInsurance(Insurance insurance );
       
    }
}
