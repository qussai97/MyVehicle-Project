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
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService )
        {
            this.loginService = loginService;
        }

        [HttpDelete("delete")]
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteLogin(Login login)
        {
            return loginService.DeleteLogin(login);
        }

        [HttpGet]
        [Route("GetAllLogin")]
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Login> GetAllLogin()
        {
            return loginService.GetAllLogin();
        }


        [HttpGet]
        [Route("GetLoginById")]
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Login GetLoginById(Login login)
        {
            return loginService.GetLoginById(login);
        }

        [HttpPost]
        
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertLogin([FromBody]Login login)
        {
            return loginService.InsertLogin(login);
        }
        [HttpPut]

        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateLogin(Login login)
        {
            return loginService.UpdateLogin(login);
        }

    }
}
