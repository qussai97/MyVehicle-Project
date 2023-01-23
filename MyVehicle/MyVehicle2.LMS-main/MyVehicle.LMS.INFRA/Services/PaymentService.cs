using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepoisitory paymentRepoisitory ;
        public PaymentService(IPaymentRepoisitory paymentRepoisitory)
        {
            this.paymentRepoisitory = paymentRepoisitory;
        }
        public bool DeletePayment(Payment payment)
        {
           return paymentRepoisitory.DeletePayment(payment);
        }

        public List<Payment> GetAllPayments()
        {
            return paymentRepoisitory.GetAllPayments();
        }

        public Payment GetAllPaymentsById(Payment payment)
        {
            return paymentRepoisitory.GetAllPaymentsById(payment);
        }

        public NumberOfPayment GetCountPayment()
        {
            return paymentRepoisitory.GetCountPayment();
        }

        public List<TotalPayment> GetTotalPaymentInDay(SearchByPaymantDate searchByPaymantDate)
        {
            return paymentRepoisitory.GetTotalPaymentInDay(searchByPaymantDate);
        }

        public bool InsertPayment(Payment payment)
        {
            return paymentRepoisitory.InsertPayment(payment);
        }

        public bool UpdatePayment(Payment payment)
        {
            return paymentRepoisitory.UpdatePayment(payment);
        }
    }
}
