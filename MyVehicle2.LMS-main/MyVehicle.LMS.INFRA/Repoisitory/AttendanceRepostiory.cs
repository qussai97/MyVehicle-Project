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
    public class AttendanceRepostiory : IAttendanceRepository
    {
        private readonly IDBContext dBContext;
        public AttendanceRepostiory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteAttendance(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@AttendanceId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteAttendance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Attendance> GetAllAttendance()
        {
            IEnumerable<Attendance> reselt = dBContext.Connection.Query<Attendance>("GetAllAttendance", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool InsertAttendance(Attendance attendance)
        {
      
        var Parameters = new DynamicParameters();
            Parameters.Add("@AtStartDate", attendance.AtStartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@AtEndDate", attendance.AtEndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@AtStatus", attendance.AtStatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", attendance.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertAttendance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateAttendance(Attendance attendance)
        {
            var Parameters = new DynamicParameters();

            Parameters.Add("@AttendanceId", attendance.AttendanceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@AtStartDate", attendance.AtStartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@AtEndDate", attendance.AtEndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@AtStatus", attendance.AtStatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", attendance.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateAttendance", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
