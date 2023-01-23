using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
   public class ReviewRepoisitory: IReviewRepoisitory
    {
        private readonly IDBContext dBContext;

        public ReviewRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool InsertReview(Review Rev)
        {
            var RevParameter = new DynamicParameters();
            RevParameter.Add("@ReviewValue", Rev.ReviewValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            RevParameter.Add("@SettingId", Rev.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertReview", RevParameter, commandType: CommandType.StoredProcedure);
            return true;

        }

        public bool UpdateReview(Review Rev)
        {
            var RevParameter = new DynamicParameters();
            RevParameter.Add("@ReviewId", Rev.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            RevParameter.Add("@ReviewValue", Rev.ReviewValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            RevParameter.Add("@SettingId", Rev.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("UpdateReview", RevParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
