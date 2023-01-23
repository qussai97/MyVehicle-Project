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
    public class BankCardRepoisitory : IBankCardRepoisitory
    {

        private IDBContext dBContext;


        public BankCardRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }
        public bool DeleteBankCard(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@BankCardId",id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteBankCard", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<BankCard> GetAllBankCard()
        {
            IEnumerable<BankCard> result = dBContext.Connection.Query<BankCard>("GetAllBankCard", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public BankCard GetBankCardById(BankCard bankCard)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@BankCardId", bankCard.BankCardId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<BankCard>("GetBankCardById", parameter, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertBankCard(BankCard bankCard)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@BankNumber", bankCard.BankNumber, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankName", bankCard.BankName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankDate", bankCard.BankDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankAmount", bankCard.BankAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankPassword", bankCard.BankPassword, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@SettingId", bankCard.SettingId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertBankCard", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateBankCard(BankCard bankCard)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@BankCardId", bankCard.BankCardId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankNumber", bankCard.BankNumber, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankName", bankCard.BankName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankDate", bankCard.BankDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankAmount", bankCard.BankAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@BankPassword", bankCard.BankPassword, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@SettingId", bankCard.SettingId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertBankCard", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
