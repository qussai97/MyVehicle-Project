using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IJwtRepository
    {
        public UsernameRolename AddAuthentication(UsernamePassword usernamePassword);
    }
}
