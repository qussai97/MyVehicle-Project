using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly IDBContext dBContext;
        public UserRegistrationRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool UserRegistration(NewUser newUser)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Username", newUser.Username, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@Password", newUser.Password, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@RoleId", newUser.RoleId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@FullName", newUser.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@UserImage", newUser.UserImage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Gender", newUser.Gender, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            parameters.Add("@Age", newUser.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Email", newUser.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PhoneNumber", newUser.PhoneNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);

            parameters.Add("@Address", newUser.Address, dbType: DbType.String, direction: ParameterDirection.Input);


            parameters.Add("@SettingId", newUser.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("UserRegistration", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
