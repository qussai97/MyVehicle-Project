using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [HttpDelete("delete")]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeletePayment(Payment payment)
        {
            return paymentService.DeletePayment(payment);
        }

        [HttpGet]
        [Route("GetAllPayments")]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Payment> GetAllPayments()
        {
            return paymentService.GetAllPayments();
        }

        [HttpGet]
        [Route("GetAllPaymentsById")]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Payment GetAllPaymentsById(Payment payment)
        {
            return paymentService.GetAllPaymentsById(payment);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertPayment([FromBody] Payment payment)
        {
            return paymentService.InsertPayment(payment);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdatePayment(Payment payment)
        {
            return paymentService.UpdatePayment(payment);
        }
        [HttpGet]
        [Route("GetCountPayment")]
        [ProducesResponseType(typeof(List<NumberOfPayment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public NumberOfPayment GetCountPayment()
        {
            return paymentService.GetCountPayment();
        }
        [HttpPost]
        [Route("GetTotalPaymentInDay")]
        [ProducesResponseType(typeof(List<TotalPayment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<TotalPayment> GetTotalPaymentInDay([FromBody]SearchByPaymantDate searchByPaymantDate)
        {
            return paymentService.GetTotalPaymentInDay(searchByPaymantDate);
        }


    }
}
