using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.DTO
{
   public class EmployeesSalaries
    {
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
    }
}
