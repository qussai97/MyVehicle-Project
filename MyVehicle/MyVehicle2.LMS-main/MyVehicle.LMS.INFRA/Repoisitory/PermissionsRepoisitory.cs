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
   public class PermissionsRepoisitory: IPermissionsRepoisitory
    {
        private readonly IDBContext dBContext;
        public PermissionsRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool InsertPermissions(int RoleId)
        {
            var PerParameter = new DynamicParameters();
            PerParameter.Add("@RoleId", RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertPermissions", PerParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdatePermissions(Permissions Per)
        {
            var PerParameter = new DynamicParameters();
            PerParameter.Add("@VehicleId", Per.PermissionsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            PerParameter.Add("@VehicleName", Per.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("UpdatePermissions", PerParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeletePermissions(int PermissionsId)
        {
            var PerParameter = new DynamicParameters();
            PerParameter.Add("@PermissionsId", PermissionsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("DeletePermissions", PerParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Permissions> GetAllPermissions()
        {
            IEnumerable<Permissions>
            Result = dBContext.Connection.Query<Permissions>("GetAllPermissions", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }
    }
}
