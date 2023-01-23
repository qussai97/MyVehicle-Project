using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IMailService
    {
        public bool SendEmailAsync(MailRequest mailRequest);
    }
}
