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
    public class RoleRepoisitory : IRoleRepoisitory
    {
        private readonly IDBContext dBContext;
        public RoleRepoisitory (IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteRole(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@RoleId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateRole", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Role> GetAllRole()
        {
            IEnumerable<Role> result = dBContext.Connection.Query<Role>("GetAllRole", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public Role GetRoleById(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@RoleId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Role>("GetRoleById", Parameters,commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertRole(Role role)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@RoleName", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var Reselt = dBContext.Connection.ExecuteAsync("InsertRole", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateRole(Role role)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@RoleId", role.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@RoleName", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateRole", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
