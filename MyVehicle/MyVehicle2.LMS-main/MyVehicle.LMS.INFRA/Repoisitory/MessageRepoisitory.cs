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
    public class MessageRepoisitory : IMessageRepoisitory
    {
        private readonly IDBContext dBContext;
        public MessageRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool InsertMessage(Message Mes)
        {
            var MesParameter = new DynamicParameters();
            MesParameter.Add("@MessageText", Mes.MessageText, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageStatus", Mes.MessageStatus, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            MesParameter.Add("@SenderName", Mes.SenderName, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageTitle", Mes.MessageTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageDate", Mes.MessageDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            MesParameter.Add("@UserId", Mes.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertMessage", MesParameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateMessage(Message Mes)
        {
            var MesParameter = new DynamicParameters();
            MesParameter.Add("@MessageId", Mes.MessageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageText", Mes.MessageText, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageStatus", Mes.MessageStatus, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            MesParameter.Add("@SenderName", Mes.SenderName, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageTitle", Mes.MessageTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            MesParameter.Add("@MessageDate", Mes.MessageDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            MesParameter.Add("@UserId", Mes.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("UpdateMessage", MesParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteMessage(int MessageId)
        {
            var MesParameter = new DynamicParameters();
            MesParameter.Add("@MessageId", MessageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("DeleteMessage", MesParameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Message> GetAllMessage()
        {
            IEnumerable<Message>
            Result = dBContext.Connection.Query<Message>("GetAllMessage", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public List<Message> GetMessageByUserId(int UserId)
        {
            var MesParameter = new DynamicParameters();
            MesParameter.Add("@UserId", UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Message>
            Result = dBContext.Connection.Query<Message>("GetMessageByUserId", MesParameter, commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }
    }
}
