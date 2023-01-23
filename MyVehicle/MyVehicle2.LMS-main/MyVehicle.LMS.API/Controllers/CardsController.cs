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
    public class CardsController : ControllerBase
    {
        private readonly ICardService cardService;
        public CardsController(ICardService cardService)
        {
            this.cardService = cardService;
        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<Cards>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCards(int id)
        {
            return cardService.DeleteCards(id);
        }
        [HttpGet]
        [Route("GetAllCards")]
        [ProducesResponseType(typeof(List<Cards>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Cards> GetAllCards()
        {
            return cardService.GetAllCards();
        }
        [HttpGet]
        [Route("GetCardById/{UserId}")]
        [ProducesResponseType(typeof(List<Cards>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Cards> GetCardById(int UserId)
        {
            return cardService.GetCardById(UserId);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Cards>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertCards([FromBody] Cards cards)
        {
            return cardService.InsertCards(cards);

        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Cards>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCards([FromBody] Cards cards)
        {
            return cardService.UpdateCards(cards);
        }
    }
}
