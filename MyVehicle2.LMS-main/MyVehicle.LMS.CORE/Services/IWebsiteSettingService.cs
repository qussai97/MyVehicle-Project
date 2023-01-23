using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IWebsiteSettingService
    {
        public List<WebsiteSetting> GetAllWebsiteSetting();

        public bool InsertWebsiteSetting(WebsiteSetting websiteSetting);
        public bool UpdateWebsiteSetting(WebsiteSetting websiteSetting);
        public bool DeleteWebsiteSetting(int id);
    }
}
