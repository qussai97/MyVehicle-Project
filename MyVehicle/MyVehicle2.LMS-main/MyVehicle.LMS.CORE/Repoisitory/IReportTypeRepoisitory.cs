using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
  public  interface IReportTypeRepoisitory
    {
        public bool InsertReportType(ReportType reportType);
        public bool DeleteReportType(int id);

    }
}
