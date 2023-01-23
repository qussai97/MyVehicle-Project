using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IMessageRepoisitory
    {
        public bool InsertMessage(Message Mes);
        public bool UpdateMessage(Message Mes);
        public bool DeleteMessage(int MessageId);
        public List<Message> GetAllMessage();

        public List<Message> GetMessageByUserId(int UserId);

    }
}
