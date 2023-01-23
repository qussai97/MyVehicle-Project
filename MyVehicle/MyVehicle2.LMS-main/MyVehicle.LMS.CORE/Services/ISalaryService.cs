using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
     public interface ISalaryService
    {
        public bool InsertSalary(Salary1 salary);
        public bool UpdateSalary(Salary1 salary);
        public bool DeleteSalary(Salary1 salary);
        public List<Salary1> GetAllSalary();
        public List<Salary1> GetSalaryById(int UserId);

        //Get Total Month Salaries For Employees //Admin
        public IEnumerable<TotalMonthSalaries> TotalMonthSalaries(SearchByMonthSalary searchByMonthSalary);
    }
}
