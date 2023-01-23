using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.DTO
{
   public class ObtainFinancialReportsDTO
    {
        //users//
        public string FullName { get; set; }
        public string UserImage { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public double? Tracks { get; set; }
        public double? Incentives { get; set; }
        public DateTime MonthSalary { get; set; }
        public double TotalSalary { get; set; }
        public DateTime AtStartDate { get; set; }
        public DateTime AtEndDate { get; set; }
        public bool AtStatus { get; set; }



    }
}
