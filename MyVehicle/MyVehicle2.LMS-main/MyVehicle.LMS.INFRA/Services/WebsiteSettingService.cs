using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class WebsiteSettingService: IWebsiteSettingService
    {
        private readonly IWebsiteSettingRepoisitory websiteSettingRepoisitory ;
        public WebsiteSettingService(IWebsiteSettingRepoisitory websiteSettingRepoisitory)
        {
            this.websiteSettingRepoisitory = websiteSettingRepoisitory;
        }

        public bool DeleteWebsiteSetting(int id)
        {
            return websiteSettingRepoisitory.DeleteWebsiteSetting(id);
        }

        public List<WebsiteSetting> GetAllWebsiteSetting()
        {
            return websiteSettingRepoisitory.GetAllWebsiteSetting();
        }

        public bool InsertWebsiteSetting(WebsiteSetting websiteSetting)
        {
            return websiteSettingRepoisitory.InsertWebsiteSetting(websiteSetting);
        }

        public bool UpdateWebsiteSetting(WebsiteSetting websiteSetting)
        {
            return websiteSettingRepoisitory.UpdateWebsiteSetting(websiteSetting);
        }
    }
}
