using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class UsersService: IUsersService
    {
        private readonly IUsersRepoisitory usersRepoisitory;
        public UsersService(IUsersRepoisitory usersRepoisitory)
        {
            this.usersRepoisitory = usersRepoisitory;
        }

        public IEnumerable<CountUserCars> CountUserCars(int UserId)
        {
            return usersRepoisitory.CountUserCars(UserId);
        }

        public bool DeleteUsers(int id)
        {
            return usersRepoisitory.DeleteUsers(id);
        }

        public List<EmployeesSalaries> EmployeesSalaries()
        {
            return usersRepoisitory.EmployeesSalaries();
        }

        public List<Users> GetAllUsers()
        {
            return usersRepoisitory.GetAllUsers();
        }

        public Users GetAllUsersById(int id)
        {
            return usersRepoisitory.GetAllUsersById(id);
        }

        public bool InsertUsers(Users users)
        {
            return usersRepoisitory.InsertUsers(users);
        }

        public IEnumerable<NumberOfEmployees> NumberOfEmployees()
        {
            return usersRepoisitory.NumberOfEmployees();
        }

        public IEnumerable<NumberOfUsers> NumberOfUsers()
        {
            return usersRepoisitory.NumberOfUsers();
        }

        public List<VehiclesUsers> SearchByUserId(int UserId)
        {
            return usersRepoisitory.SearchByUserId(UserId);
        }

        public bool UpdateUsers(Users users)
        {
            return usersRepoisitory.UpdateUsers(users);
        }
        public List<GetDrivingLicenseDTO> GetDrivingLicense(int UserId)
        {
            return usersRepoisitory.GetDrivingLicense(UserId);
        }
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports()
        {
            return usersRepoisitory.ObtainFinancialReports();
        }
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(SearchingForVehiclesLicenseExpiry paymentDate)
        {
            return usersRepoisitory.ViewUserContactInformation(paymentDate);
        }

        public List<ListOfEmployees> GetListOfEmployees()
        {
            return usersRepoisitory.GetListOfEmployees();
        }

        public IEnumerable<NumberOfAllUser> GetNumberOfAllUser()
        {
            return usersRepoisitory.GetNumberOfAllUser();
        }
    }
}
