using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepoisitory messageRepoisitory;
        public MessageService(IMessageRepoisitory messageRepoisitory)
        {
            this.messageRepoisitory = messageRepoisitory;
        }
        public bool InsertMessage(Message Mes)
        {
            return messageRepoisitory.InsertMessage(Mes);
        }

        public bool UpdateMessage(Message Mes)
        {
            return messageRepoisitory.UpdateMessage(Mes);
        }
        public bool DeleteMessage(int MessageId)
        {
            return messageRepoisitory.DeleteMessage(MessageId);
        }

        public List<Message> GetAllMessage()
        {
            return messageRepoisitory.GetAllMessage();
        }

        public List<Message> GetMessageByUserId(int UserId)
        {
            return messageRepoisitory.GetMessageByUserId(UserId);
        }
    }
}
