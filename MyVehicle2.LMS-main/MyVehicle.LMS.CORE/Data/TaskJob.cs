using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class TaskJob
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }

    }
}
