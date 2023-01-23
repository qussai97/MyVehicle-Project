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
    public class ContactRepoisitory : IContactRepoisitory
    {
        private readonly IDBContext dBContext;
        public ContactRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteContact(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ContactId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("DeleteContact", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Contact> GetAllContact()
        {
           IEnumerable<Contact> Reselt = dBContext.Connection.Query<Contact>("GetAllContact", commandType: CommandType.StoredProcedure);

           return Reselt.ToList();
            
        }

        public bool InsertContact(Contact contact)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@Facebook", contact.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Instagram", contact.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Twitter", contact.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber1", contact.PhoneNumber1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber2", contact.PhoneNumber2, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", contact.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("InsertContact", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateContact(Contact contact)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ContactId", contact.ContactId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Parameters.Add("@Facebook", contact.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Instagram", contact.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Twitter", contact.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber1", contact.PhoneNumber1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber2", contact.PhoneNumber2, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", contact.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateContact", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
