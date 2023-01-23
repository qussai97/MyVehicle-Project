using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly IUserRegistrationRepository userRegistrationRepository  ;
        public UserRegistrationService(IUserRegistrationRepository userRegistrationRepository)
        {
            this.userRegistrationRepository = userRegistrationRepository;
        }

        public bool UserRegistration(NewUser newUser)
        {
            return userRegistrationRepository.UserRegistration(newUser);
        }
    }
}
