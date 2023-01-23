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
   public class WebsiteSettingRepoisitory: IWebsiteSettingRepoisitory
    {
        private IDBContext dBContext;


        public WebsiteSettingRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }

        public bool DeleteWebsiteSetting(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@SettingId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteWebsiteSetting", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<WebsiteSetting> GetAllWebsiteSetting()
        {
            IEnumerable<WebsiteSetting> result = dBContext.Connection.Query<WebsiteSetting>("GetAllWebsiteSetting", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool InsertWebsiteSetting(WebsiteSetting websiteSetting)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@WebName", websiteSetting.WebName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@WebLogo", websiteSetting.WebLogo, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@WebBackground", websiteSetting.WebBackground, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            
            var result = dBContext.Connection.ExecuteAsync("InsertWebsiteSetting", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateWebsiteSetting(WebsiteSetting websiteSetting)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@SettingId", websiteSetting.SettingId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@WebName", websiteSetting.WebName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@WebLogo", websiteSetting.WebLogo, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@WebBackground", websiteSetting.WebBackground, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertWebsiteSetting", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
