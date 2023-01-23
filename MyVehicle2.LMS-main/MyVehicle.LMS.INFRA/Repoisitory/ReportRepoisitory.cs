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
    public class ReportRepoisitory : IReportRepoisitory
    {
        private IDBContext dBContext;


        public ReportRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }

        public List<Report> GetAllReport()
        {
            IEnumerable<Report> result = dBContext.Connection.Query<Report>("GetAllReport", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool InsertReport(Report report)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReportDate", report.ReportDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ReportFile", report.ReportFile, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@UserId", report.UserId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@ReportTypeId",report.ReportTypeId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("InsertReport", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
