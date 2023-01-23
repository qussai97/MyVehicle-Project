using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
    public interface IAttendanceRepository
    {
         
        public bool InsertAttendance(Attendance attendance);
        public bool UpdateAttendance(Attendance attendance);
        public bool DeleteAttendance(int id);
        public List<Attendance> GetAllAttendance();
    }
}
