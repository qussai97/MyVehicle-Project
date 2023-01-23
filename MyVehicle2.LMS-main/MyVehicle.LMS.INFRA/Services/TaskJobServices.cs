using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class TaskJobServices: ITaskJobServices
    {
        private readonly ITaskJobRepoisitory taskJobRepoisitory;
        public TaskJobServices(ITaskJobRepoisitory taskJobRepoisitory)
        {
            this.taskJobRepoisitory = taskJobRepoisitory;
        }
        public bool InsertTaskJob(TaskJob Task)
        {
            return taskJobRepoisitory.InsertTaskJob(Task);
        }

        public bool UpdateTaskJob(TaskJob Task)
        {
            return taskJobRepoisitory.UpdateTaskJob(Task);
        }
        public bool DeleteTaskJob(int TaskId)
        {
            return taskJobRepoisitory.DeleteTaskJob(TaskId);
        }

        public List<TaskJob> GetAllTaskJob()
        {
            return taskJobRepoisitory.GetAllTaskJob();

        }
        public List<TaskJob> TaskJobById(int UserId)
        {
            return taskJobRepoisitory.TaskJobById(UserId);
        }

    }
}
