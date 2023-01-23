using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportTypeController : ControllerBase
    {
        private readonly IReportTypeService reportTypeService;
        public ReportTypeController(IReportTypeService reportTypeService)
        {
            this.reportTypeService = reportTypeService;
        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<ReportType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteReportType(int id)
        {
            return reportTypeService.DeleteReportType(id);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<ReportType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertReportType([FromBody] ReportType reportType)
        {
            return reportTypeService.InsertReportType(reportType);
        }
    }
}
