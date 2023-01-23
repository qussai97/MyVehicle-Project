using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
    public interface INotificationRepository
    {
        public bool DeleteNotification(int NotificationId);
        public bool InsertNotification(Notification notification);
        public bool UpdateNotification(Notification notification);
        public List<Notification> GetAllNotification();
    }
}
