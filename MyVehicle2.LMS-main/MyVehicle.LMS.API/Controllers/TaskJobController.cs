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
    public class TaskJobController : ControllerBase
    {
        private readonly ITaskJobServices taskJobServices;
        public TaskJobController(ITaskJobServices taskJobServices)
        {
            this.taskJobServices = taskJobServices;
        }
        [HttpPost]
        [Route("InsertTaskJob")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertTaskJob([FromBody]TaskJob Task)
        {
            return taskJobServices.InsertTaskJob(Task);
        }
        [HttpPut]
        [Route("UpdateTaskJob")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTaskJob(TaskJob Task)
        {
            return taskJobServices.UpdateTaskJob(Task);
        }
        [HttpDelete]
        [Route("DeleteTaskJob")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteTaskJob(int TaskId)
        {
            return taskJobServices.DeleteTaskJob(TaskId);
        }
        [HttpGet]
        [Route("GetAllTaskJob")]
        [ProducesResponseType(typeof(List<TaskJob>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<TaskJob> GetAllTaskJob()
        {
            return taskJobServices.GetAllTaskJob();


        }
        [HttpGet]
        [Route("TaskJobById/{UserId}")]
        [ProducesResponseType(typeof(List<TaskJob>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<TaskJob> TaskJobById(int UserId)
        {
            return taskJobServices.TaskJobById(UserId);
        }
    }

}
