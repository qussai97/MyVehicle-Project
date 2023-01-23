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
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService;
        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        [HttpPost]
        [Route("InsertMessage")]
        public bool InsertMessage([FromBody]Message Mes)
        {
            return messageService.InsertMessage(Mes);
        }
        [HttpPut]
        [Route("UpdateMessage")]
        public bool UpdateMessage(Message Mes)
        {
            return messageService.UpdateMessage(Mes);
        }
        [HttpDelete]
        [Route("DeleteMessage")]
        public bool DeleteMessage(int MessageId)
        {
            return messageService.DeleteMessage(MessageId);
        }
        [HttpGet]
        [Route("GetAllMessage")]
        public List<Message> GetAllMessage()
        {
            return messageService.GetAllMessage();
        }

        [HttpGet]
        [Route("GetMessageByUserId/{UserId}")]
        
        public List<Message> GetMessageByUserId(int UserId)
        {
            return messageService.GetMessageByUserId(UserId);
        }
    }
}
