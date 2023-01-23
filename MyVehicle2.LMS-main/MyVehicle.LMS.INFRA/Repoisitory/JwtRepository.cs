using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class JwtRepository : IJwtRepository

    {
        private readonly IDBContext dBContext;
        public JwtRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public UsernameRolename AddAuthentication(UsernamePassword usernamePassword)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Username", usernamePassword.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Password", usernamePassword.Password, dbType: DbType.String, direction: ParameterDirection.Input); 
            IEnumerable<UsernameRolename> result =dBContext.Connection.Query<UsernameRolename>("AddAuthentication", parameters, commandType: CommandType.StoredProcedure); 
            return result.FirstOrDefault();
        }
    }
}
