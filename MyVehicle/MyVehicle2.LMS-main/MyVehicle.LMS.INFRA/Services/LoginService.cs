using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class LoginService: ILoginService
    {
        private readonly ILoginRepoisitory loginRepoisitory ;
        public LoginService(ILoginRepoisitory loginRepoisitory)
        {
            this.loginRepoisitory = loginRepoisitory;
        }

        public bool DeleteLogin(Login login)
        {
            return loginRepoisitory.DeleteLogin(login);
        }

        public List<Login> GetAllLogin()
        {
            return loginRepoisitory.GetAllLogin();
        }

        public Login GetLoginById(Login login)
        {
            return loginRepoisitory.GetLoginById(login);
        }

        public bool InsertLogin(Login login)
        {
            return loginRepoisitory.InsertLogin(login);
        }

        public bool UpdateLogin(Login login)
        {
            return loginRepoisitory.UpdateLogin(login);
        }
    }
}
