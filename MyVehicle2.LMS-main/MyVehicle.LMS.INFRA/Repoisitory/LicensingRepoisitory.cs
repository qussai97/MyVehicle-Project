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
   public class LicensingRepoisitory: ILicensingRepoisitory
    {

        private IDBContext dBContext;


        public LicensingRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }

        public List<Licensing> GetAllLicensing()
        {
            IEnumerable<Licensing> result = dBContext.Connection.Query<Licensing>("GetAllLicensing", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool InsertLicensing(Licensing licensing)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@MinValue", licensing.MinValue, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MaxValue", licensing.MaxValue, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EngineType", licensing.EngineType, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@NumberPassengers", licensing.NumberPassengers, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Cost", licensing.Cost, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("InsertLicensing", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public GetCost SearchInfo(EngineCapacityAndType capacityAndType)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@EngineCapacity", capacityAndType.EngineCapacity, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);


            parameters.Add("@EngineType", capacityAndType.EngineType, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);


            var result = dBContext.Connection.Query<GetCost>("SearchInfo", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public PaymentCost SearchLicensingCost(SearchLicensingCostByEngineCapasty searchLicensingCostByEngineCapasty)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@EngineCapasty", searchLicensingCostByEngineCapasty.EngineCapasty, dbType: DbType.Double, direction: System.Data.ParameterDirection.Input);

           var result = dBContext.Connection.Query<PaymentCost>("SearchLicensingCost", Parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public bool UpdateLicensing(Licensing licensing)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LicensingId", licensing.LicensingId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            parameters.Add("@MinValue", licensing.MinValue, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@MaxValue", licensing.MaxValue, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@EngineType", licensing.EngineType, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@NumberPassengers", licensing.NumberPassengers, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Cost", licensing.Cost, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateLicensing", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        
    }
}
