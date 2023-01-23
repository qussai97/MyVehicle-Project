using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class InsuranceRepoisitory: IInsuranceRepoisitory
    {
        private IDBContext dBContext;


        public InsuranceRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;

        }

        public List<Insurance> GetAllInsurance()
        {
            IEnumerable<Insurance> result = dBContext.Connection.Query<Insurance>("GetAllInsurance", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool InsertInsurance(Insurance insurance)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@InsuranceType", insurance.InsuranceType, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@InsuranceValues", insurance.InsuranceValues, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
           
            var result = dBContext.Connection.ExecuteAsync("InsertInsurance", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateInsurance(Insurance insurance)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@InsuranceId", insurance.InsuranceId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            parameters.Add("@InsuranceType", insurance.InsuranceType, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@InsuranceValues", insurance.InsuranceValues, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateInsurance", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
