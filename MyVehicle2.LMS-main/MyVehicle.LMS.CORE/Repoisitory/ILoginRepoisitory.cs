using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
    public interface ILoginRepoisitory
    {
        public List<Login> GetAllLogin();

        public bool InsertLogin(Login login );
        public bool UpdateLogin(Login login);
        public bool DeleteLogin(Login login);
        public Login GetLoginById(Login login);
    }
}
