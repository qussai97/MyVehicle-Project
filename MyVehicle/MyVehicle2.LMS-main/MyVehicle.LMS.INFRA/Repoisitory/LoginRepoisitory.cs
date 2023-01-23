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
    public class LoginRepoisitory: ILoginRepoisitory
    {
        private IDBContext dBContext;


        public LoginRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteLogin(Login login)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@LoginId", login.loginId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteLogin", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Login> GetAllLogin()
        {
            IEnumerable<Login> result = dBContext.Connection.Query<Login>("GetAllLogin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Login GetLoginById(Login login)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@LoginId", login.loginId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Login>("GetLoginById", parameter, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertLogin(Login login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Username", login.Username, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@RoleId", login.RoleId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("InsertLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateLogin(Login login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LoginId", login.loginId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Username", login.Username, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@RoleId", login.RoleId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
           
            var result = dBContext.Connection.ExecuteAsync("UpdateLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
