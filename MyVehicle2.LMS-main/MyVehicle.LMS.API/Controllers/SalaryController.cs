using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService salaryService;
        public SalaryController(ISalaryService salaryService)
        {
            this.salaryService = salaryService;
        }
        [HttpDelete("delete")]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteSalary([FromBody] Salary1 Salary)
        {
            return salaryService.DeleteSalary(Salary);
        }
        [HttpGet]
        [Route("GetAllSalary")]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Salary1> GetAllSalary()
        {
            return salaryService.GetAllSalary();
        }
        [HttpGet]
        [Route("GetSalaryById/{UserId}")]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Salary1> GetSalaryById(int UserId)
        {
            return salaryService.GetSalaryById(UserId);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertSalary([FromBody] Salary1 Salary)
        {
            return salaryService.InsertSalary(Salary);

        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateSalary([FromBody] Salary1 Salary)
        {
            return salaryService.UpdateSalary(Salary);
        }

        [HttpPost]
        [Route("TotalMonthSalaries")]
        [ProducesResponseType(typeof(List<Salary1>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<TotalMonthSalaries> TotalMonthSalaries([FromBody]SearchByMonthSalary searchByMonthSalary)
        {
            return salaryService.TotalMonthSalaries(searchByMonthSalary);
        }

        
    }
}
