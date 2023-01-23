using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteSettingController : ControllerBase
    {
        private readonly IWebsiteSettingService websiteSettingService;
        public WebsiteSettingController(IWebsiteSettingService websiteSettingService)
        {
            this.websiteSettingService = websiteSettingService;
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<WebsiteSetting>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteWebsiteSetting(int id)
        {
            return websiteSettingService.DeleteWebsiteSetting(id);
        }

        [HttpGet]
        [Route("GetAllWebsiteSetting")]
        [ProducesResponseType(typeof(List<WebsiteSetting>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<WebsiteSetting> GetAllWebsiteSetting()
        {
            return websiteSettingService.GetAllWebsiteSetting();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<WebsiteSetting>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertWebsiteSetting([FromBody]WebsiteSetting websiteSetting)
        {
            return websiteSettingService.InsertWebsiteSetting(websiteSetting);
        }


        [HttpPut]
        [ProducesResponseType(typeof(List<WebsiteSetting>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateWebsiteSetting(WebsiteSetting websiteSetting)
        {
            return websiteSettingService.UpdateWebsiteSetting(websiteSetting);
        }
    }
}
