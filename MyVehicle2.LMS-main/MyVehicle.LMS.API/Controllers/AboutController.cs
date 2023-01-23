using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;
        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<About>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteAbout(int id)
        {
            return aboutService.DeleteAbout(id);
        }

        [HttpGet]
        [Route("GetAllAbout")]
        [ProducesResponseType(typeof(List<About>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<About> GetAllAbout()
        {
            return aboutService.GetAllAbout();
        }


        [HttpPost]
        [ProducesResponseType(typeof(List<About>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertAbout([FromBody] About about)
        {
            return aboutService.InsertAbout(about);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<About>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateAbout(About about)
        {
            return aboutService.UpdateAbout(about);
        }

    }
}
