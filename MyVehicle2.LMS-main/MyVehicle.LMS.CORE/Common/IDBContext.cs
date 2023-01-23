using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MyVehicle.LMS.CORE.Common
{
    public interface IDBContext
    {
        public DbConnection Connection { get; }
    }
}
