using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class ReportTypeService: IReportTypeService
    {
        private readonly IReportTypeRepoisitory reportTypeRepoisitory;
        public ReportTypeService(IReportTypeRepoisitory reportTypeRepoisitory)
        {
            this.reportTypeRepoisitory = reportTypeRepoisitory;
        }

        public bool DeleteReportType(int id)
        {
            return reportTypeRepoisitory.DeleteReportType(id);
        }

        public bool InsertReportType(ReportType reportType)
        {
            return reportTypeRepoisitory.InsertReportType(reportType);
        }
    }
}
