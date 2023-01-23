using Microsoft.Extensions.Configuration;
using MyVehicle.LMS.CORE.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace MyVehicle.LMS.INFRA.Common
{
    public class DBContext: IDBContext
    {
        private DbConnection _Connection;
        public readonly IConfiguration configuration;

        public DBContext(IConfiguration Configuration)
        {
            this.configuration = Configuration;
        }

        public DbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SqlConnection(configuration["ConnectionStrings:DBConnectionString"]);

                    _Connection.Open();
                }
                else if (_Connection.State != ConnectionState.Open)
                {
                    _Connection.Open();
                }
                return _Connection;
            }
        }
    }
}
