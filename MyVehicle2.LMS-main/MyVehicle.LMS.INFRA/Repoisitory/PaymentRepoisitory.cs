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
    public class PaymentRepoisitory : IPaymentRepoisitory
    {
        private IDBContext dBContext;


        public PaymentRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeletePayment(Payment payment)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@PaymentId", payment.PaymentId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeletePayment", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Payment> GetAllPayments()
        {
            IEnumerable<Payment> result = dBContext.Connection.Query<Payment>("GetAllPayments", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Payment GetAllPaymentsById(Payment payment)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@PaymentId", payment.PaymentId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Query<Payment>("GetAllPaymentsById", parameter, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public NumberOfPayment GetCountPayment()
        {
            var result = dBContext.Connection.Query<NumberOfPayment>("GetCountPayment", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool InsertPayment(Payment payment)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@PaymentDate", payment.PaymentDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentAmount", payment.PaymentAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@UserId", payment.UserId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("InsertPayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<TotalPayment> GetTotalPaymentInDay(SearchByPaymantDate searchByPaymantDate)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@PaymantDate", searchByPaymantDate.PaymantDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            IEnumerable<TotalPayment> reselt = dBContext.Connection.Query<TotalPayment>("GetTotalPaymentInDay", parameters, commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool UpdatePayment(Payment payment)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@PaymentId", payment.PaymentId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentDate", payment.PaymentDate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@PaymentAmount", payment.PaymentAmount, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@UserId", payment.UserId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdatePayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
