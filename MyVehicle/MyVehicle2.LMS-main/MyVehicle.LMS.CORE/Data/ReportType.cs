using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class ReportType
    {
        [Key]
        public int ReportTypeId { get; set; }
        public string ReportTypeName { get; set; }

        public ICollection<Report> Reports { get; set; }


    }
}
