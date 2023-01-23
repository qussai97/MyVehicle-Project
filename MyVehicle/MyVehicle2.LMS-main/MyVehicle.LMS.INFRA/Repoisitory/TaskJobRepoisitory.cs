using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class TaskJobRepoisitory : ITaskJobRepoisitory
    {
        private readonly IDBContext dBContext;
        public TaskJobRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool InsertTaskJob(TaskJob Task)
        {
            var TaskParameter = new DynamicParameters();
            TaskParameter.Add("@TaskDescription", Task.TaskDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            TaskParameter.Add("@TaskDate", Task.TaskDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            TaskParameter.Add("@UserId", Task.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertTaskJob", TaskParameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTaskJob(TaskJob Task)
        {
            var TaskParameter = new DynamicParameters();
            TaskParameter.Add("@TaskId", Task.TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            TaskParameter.Add("@TaskDescription", Task.TaskDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            TaskParameter.Add("@TaskDate", Task.TaskDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            TaskParameter.Add("@UserId", Task.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("UpdateTaskJob", TaskParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteTaskJob(int TaskId)
        {
            var TaskParameter = new DynamicParameters();
            TaskParameter.Add("@TaskId", TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("DeleteTaskJob", TaskParameter, commandType: CommandType.StoredProcedure);
            return true;

        }

        public List<TaskJob> GetAllTaskJob()
        {
            IEnumerable<TaskJob>
           Result = dBContext.Connection.Query<TaskJob>("GetAllTaskJob", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }
        public List<TaskJob> TaskJobById(int UserId)

        {
            var VehParameter = new DynamicParameters();
            VehParameter.Add("@Userid", UserId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);

            IEnumerable<TaskJob> result = dBContext.Connection.Query<TaskJob>("GetTaskJobById", VehParameter, commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

    }
}
