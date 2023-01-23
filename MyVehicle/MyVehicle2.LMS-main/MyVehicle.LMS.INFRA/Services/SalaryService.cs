using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class SalaryService: ISalaryService
    {
        private readonly ISalaryRepoisitory salaryRepoisitory;
        public SalaryService(ISalaryRepoisitory salaryRepoisitory)
        {
            this.salaryRepoisitory = salaryRepoisitory;
        }

        public bool DeleteSalary(Salary1 salary)
        {
            return salaryRepoisitory.DeleteSalary(salary);
        }

        public List<Salary1> GetAllSalary()
        {
            return salaryRepoisitory.GetAllSalary();
        }

        public List<Salary1> GetSalaryById(int UserId)
        {
            return salaryRepoisitory.GetSalaryById(UserId);
        }

        public bool InsertSalary(Salary1 salary)
        {
            return salaryRepoisitory.InsertSalary(salary);
        }

        public IEnumerable<TotalMonthSalaries> TotalMonthSalaries(SearchByMonthSalary searchByMonthSalary)
        {
            return salaryRepoisitory.TotalMonthSalaries(searchByMonthSalary);
        }

        public bool UpdateSalary(Salary1 salary)
        {
            return salaryRepoisitory.UpdateSalary(salary);
        }
    }
}
