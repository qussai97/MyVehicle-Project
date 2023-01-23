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
   public class SalaryRepoisitory: ISalaryRepoisitory
    {
        private readonly IDBContext dBContext;
        public SalaryRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteSalary(Salary1 salary)
        {

            var Parameters = new DynamicParameters();
            Parameters.Add("@SalaryId", salary.SalaryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteSalary", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Salary1> GetAllSalary()
        {
            IEnumerable<Salary1> reselt = dBContext.Connection.Query<Salary1>("GetAllSalaries", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public List<Salary1> GetSalaryById(int UserId)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@UserId", UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var reselt = dBContext.Connection.Query<Salary1>("GetSalaryById", Parameter, commandType: CommandType.StoredProcedure);
            return reselt.ToList();
        }

        public bool InsertSalary(Salary1 salary)
        {
           
            var Parameters = new DynamicParameters();
            Parameters.Add("@Salary", salary.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@Tracks", salary.Tracks, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@Incentives", salary.Incentives, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@MonthSalary", salary.MonthSalary, dbType: DbType.Date, direction: ParameterDirection.Input);
            Parameters.Add("@TotalSalary", salary.TotalSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", salary.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("InsertSalary", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IEnumerable<TotalMonthSalaries> TotalMonthSalaries(SearchByMonthSalary searchByMonthSalary)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@StartDate", searchByMonthSalary.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            IEnumerable<TotalMonthSalaries> result = dBContext.Connection.Query<TotalMonthSalaries>("TotalMonthSalaries", Parameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool UpdateSalary(Salary1 salary)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@SalaryId", salary.SalaryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Parameters.Add("@Salary", salary.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@Tracks", salary.Tracks, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@Incentives", salary.Incentives, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@MonthSalary", salary.MonthSalary, dbType: DbType.Date, direction: ParameterDirection.Input);
            Parameters.Add("@TotalSalary", salary.TotalSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", salary.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateSalary", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
