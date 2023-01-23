using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Salary1
    {
        [Key]
        public int SalaryId { get; set; }
        public double  Salary { get; set; }
        public double ? Tracks { get; set; }
        public double ? Incentives { get; set; }
        public DateTime MonthSalary { get; set; }
        public double TotalSalary { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }
    }
}
