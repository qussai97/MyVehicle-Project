using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Message
    {

        [Key]
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public bool MessageStatus { get; set; }
        public string SenderName { get; set; }
        public string MessageTitle { get; set; }
        public DateTime MessageDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }
    }
}
