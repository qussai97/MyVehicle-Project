using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool NotificationStatus { get; set; }
        public string NotificationText { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }
    }
}
