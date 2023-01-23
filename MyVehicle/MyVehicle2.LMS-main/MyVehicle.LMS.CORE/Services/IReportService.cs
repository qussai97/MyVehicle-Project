using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IReportService
    {
        public List<Report> GetAllReport();

        public bool InsertReport(Report report);
    }
}
