using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IPaymentService
    {
        public List<Payment> GetAllPayments();

        public bool InsertPayment(Payment payment);
        public bool UpdatePayment(Payment payment);
        public bool DeletePayment(Payment payment);
        public Payment GetAllPaymentsById(Payment payment);
        // Retrive Number Of Payment

        public NumberOfPayment GetCountPayment();

        // Retrive Total Payment in day
        public List<TotalPayment> GetTotalPaymentInDay(SearchByPaymantDate searchByPaymantDate);

    }
}
