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
    public class ImagesRepository: IImagesRepository
    {
        private readonly IDBContext dBContext;
        public ImagesRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteImages(Images images)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ImagesId", images.ImagesId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteImages", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Images> GetAllImages()
        {
            IEnumerable<Images> reselt = dBContext.Connection.Query<Images>("GetAllImages", commandType: CommandType.StoredProcedure);

              return reselt.ToList();
        }

        public bool UpdateImages(Images images)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ImagesId", images.ImagesId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@ImageName", images.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", images.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateImages", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertImages(Images images)
            
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@ImageName", images.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@SettingId", images.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertImages", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Images GetImagesById(Images images)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@ImagesId", images.ImagesId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var reselt = dBContext.Connection.Query<Images>("GetImagesById", Parameter, commandType: CommandType.StoredProcedure);
            return reselt.FirstOrDefault();
        }
    }
}
