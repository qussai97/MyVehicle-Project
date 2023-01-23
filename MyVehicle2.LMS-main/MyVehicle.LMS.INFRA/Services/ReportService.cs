using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepoisitory reportRepoisitory;
        public ReportService(IReportRepoisitory reportRepoisitory)
        {
            this.reportRepoisitory = reportRepoisitory;
        }
        public List<Report> GetAllReport()
        {
            return reportRepoisitory.GetAllReport();
        }

        public bool InsertReport(Report report)
        {
            return reportRepoisitory.InsertReport(report);
        }
    }
}
