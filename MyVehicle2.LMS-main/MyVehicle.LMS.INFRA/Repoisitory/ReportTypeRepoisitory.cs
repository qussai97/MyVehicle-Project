using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
   public class ReportTypeRepoisitory: IReportTypeRepoisitory
    {
        private readonly IDBContext dBContext;
        public ReportTypeRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteReportType(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ReportTypeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("DeleteReportType", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertReportType(ReportType reportType)
        {
           var Parameters = new DynamicParameters();
            Parameters.Add("@ReportTypeName", reportType.ReportTypeName, dbType: DbType.String, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertReportType", Parameters, commandType: CommandType.StoredProcedure);
            return true;


        }
    }
}
