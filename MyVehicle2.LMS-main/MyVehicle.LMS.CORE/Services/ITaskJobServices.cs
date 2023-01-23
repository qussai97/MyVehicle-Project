using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface ITaskJobServices
    {
        public bool InsertTaskJob(TaskJob Task);
        public bool UpdateTaskJob(TaskJob Task);
        public bool DeleteTaskJob(int TaskId);
        public List<TaskJob> GetAllTaskJob();
        public List<TaskJob> TaskJobById(int UserId);


    }
}
