using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class LicensingAndInsuranceRepository : ILicensingAndInsuranceRepository
    {
        private readonly IDBContext dBContext;
        public LicensingAndInsuranceRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool CreateLicensingAndInsurance(LicensingInsurance licensingInsurance)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@VehicleId", licensingInsurance.VehicleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@LicensingId", licensingInsurance.LicensingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@InsuranceId", licensingInsurance.InsuranceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("CreateLicensingAndInsurance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<LicensingAndInsurance> GetAllLicensingAndInsurance()
        {
            IEnumerable<LicensingAndInsurance> reselt = dBContext.Connection.Query<LicensingAndInsurance>("GetAllLicensingAndInsurance", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool InsertLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance)
        {
  
         var Parameters = new DynamicParameters();
            Parameters.Add("@Value", licensingAndInsurance.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@LicensingId", licensingAndInsurance.LicensingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@InsuranceId", licensingAndInsurance.InsuranceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertLicensingAndInsurance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance)
        {
            
               var Parameters = new DynamicParameters();
            Parameters.Add("@LicenseValueId", licensingAndInsurance.LicenseValueId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@Value", licensingAndInsurance.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@LicensingId", licensingAndInsurance.LicensingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@InsuranceId", licensingAndInsurance.InsuranceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateLicensingAndInsurance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
