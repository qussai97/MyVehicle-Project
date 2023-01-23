using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class AboutRepository : IAboutRepository
    {
        private readonly IDBContext dBContext;
        public AboutRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteAbout(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@AboutId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteAbout", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<About> GetAllAbout()
        {
            IEnumerable<About> reselt = dBContext.Connection.Query<About>("GetAllAbout", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool InsertAbout(About about)
        {
      
            var Parameters = new DynamicParameters();
            Parameters.Add("@AboutImage", about.AboutImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Description", about.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", about.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertAbout", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateAbout(About about)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@AboutId", about.AboutId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@AboutImage", about.AboutImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Description", about.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", about.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateAbout", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
