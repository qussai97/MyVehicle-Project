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
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService attendanceService;
        public AttendanceController(IAttendanceService attendanceService)
        {
            this.attendanceService = attendanceService;
        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<Attendance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteAttendance(int id)
        {
            return attendanceService.DeleteAttendance(id);
        }

        [HttpGet]
        [Route("GetAllAttendance")]
        [ProducesResponseType(typeof(List<Attendance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Attendance> GetAllAttendance()
        {
            return attendanceService.GetAllAttendance();
        }


        [HttpPost]
        [ProducesResponseType(typeof(List<Attendance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertAttendance([FromBody] Attendance attendance)
        {
            return attendanceService.InsertAttendance(attendance);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Attendance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateAttendance(Attendance attendance)
        {
            return attendanceService.UpdateAttendance(attendance);
        }
    }
}
