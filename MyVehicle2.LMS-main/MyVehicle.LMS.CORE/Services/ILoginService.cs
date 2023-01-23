using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
    public interface ILoginService
    {
        public List<Login> GetAllLogin();

        public bool InsertLogin(Login login);
        public bool UpdateLogin(Login login);
        public bool DeleteLogin(Login login);
        public Login GetLoginById(Login login);
    }
}
