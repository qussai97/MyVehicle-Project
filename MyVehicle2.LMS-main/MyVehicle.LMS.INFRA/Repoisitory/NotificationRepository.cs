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
  public   class NotificationRepository: INotificationRepository
    {
        private readonly IDBContext dBContext;
        public NotificationRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

  

        public bool DeleteNotification(int NotificationId)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@NotificationId",NotificationId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteNotification", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

         
        public List<Notification> GetAllNotification()
        {
            IEnumerable<Notification> reselt = dBContext.Connection.Query<Notification>("GetAllNotification", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }



        public bool InsertNotification(Notification notification)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@NotificationDate", notification.NotificationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@NotificationStatus", notification.NotificationStatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@NotificationText", notification.NotificationText, dbType: DbType.String, direction: ParameterDirection.Input);

            Parameters.Add("@UserId", notification.UserId, dbType: DbType.String, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("InsertNotification", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

     

        public bool UpdateNotification(Notification notification)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@NotificationId", notification.NotificationId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Parameters.Add("@NotificationDate", notification.NotificationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            Parameters.Add("@NotificationStatus", notification.NotificationStatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@NotificationText", notification.NotificationText, dbType: DbType.String, direction: ParameterDirection.Input);

            Parameters.Add("@UserId", notification.UserId, dbType: DbType.String, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateNotification", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
