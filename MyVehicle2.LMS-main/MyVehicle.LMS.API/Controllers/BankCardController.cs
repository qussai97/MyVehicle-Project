using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankCardController : ControllerBase
    {
        private readonly IBankCardService bankCardService;
        public BankCardController(IBankCardService bankCardService)
        {
            this.bankCardService = bankCardService;
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<BankCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteBankCard(int id)
        {
            return bankCardService.DeleteBankCard(id);
        }

        [HttpGet]
        [Route("GetAllBankCard")]
        [ProducesResponseType(typeof(List<BankCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<BankCard> GetAllBankCard()
        {
            return bankCardService.GetAllBankCard();
        }

        [HttpGet]
        [Route("GetBankCardById")]
        [ProducesResponseType(typeof(List<BankCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public BankCard GetBankCardById(BankCard bankCard)
        {
            return bankCardService.GetBankCardById(bankCard);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<BankCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertBankCard([FromBody]BankCard bankCard)
        {
            return bankCardService.InsertBankCard(bankCard);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<BankCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateBankCard(BankCard bankCard)
        {
            return bankCardService.UpdateBankCard(bankCard);
        }

    }
}
