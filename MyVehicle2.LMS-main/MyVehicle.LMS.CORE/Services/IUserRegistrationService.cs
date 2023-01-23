using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IUserRegistrationService
    {
        public bool UserRegistration(NewUser newUser);
    }
}
