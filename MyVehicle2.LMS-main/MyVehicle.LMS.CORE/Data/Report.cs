using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
  public  class Report
    {
        [Key]
        public int ReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportFile { get; set; }
        public int UserId { get; set; }
        public int ReportTypeId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }

        [ForeignKey("ReportType")]

        public virtual ReportType ReportsType { get; set; }
    }
}
