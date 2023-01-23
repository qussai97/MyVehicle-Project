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
    public class CardsRepoisitory : ICardsRepoisitory
    {
        private readonly IDBContext dBContext;
        public CardsRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool DeleteCards(int id)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@CardId",id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("DeleteCards", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cards> GetAllCards()
        {
            IEnumerable<Cards> reselt = dBContext.Connection.Query<Cards>("GetAllCards", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public List<Cards> GetCardById(int UserId)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@UserId", UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var reselt = dBContext.Connection.Query<Cards>("GetCardById", Parameter, commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public bool InsertCards(Cards cards)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@CardNumber", cards.CardNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@CardName", cards.CardName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@CardDate", cards.CardDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", cards.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var Reselt = dBContext.Connection.ExecuteAsync("InsertCards", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCards(Cards cards)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@CardId", cards.CardId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Parameters.Add("@CardNumber", cards.CardNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@CardName", cards.CardName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@CardDate", cards.CardDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            Parameters.Add("@UserId", cards.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Reselt = dBContext.Connection.ExecuteAsync("UpdateCards", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
