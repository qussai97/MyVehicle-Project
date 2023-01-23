using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class AttendanceService: IAttendanceService
    {
        private readonly IAttendanceRepository attendanceRepository;
        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            this.attendanceRepository = attendanceRepository;
        }

        public bool DeleteAttendance(int id)
        {
            return attendanceRepository.DeleteAttendance(id);
        }

        public List<Attendance> GetAllAttendance()
        {
            return attendanceRepository.GetAllAttendance();
        }

        public bool InsertAttendance(Attendance attendance)
        {
            return attendanceRepository.InsertAttendance(attendance);
        }

        public bool UpdateAttendance(Attendance attendance)
        {
            return attendanceRepository.UpdateAttendance(attendance);
        }
    }
}
