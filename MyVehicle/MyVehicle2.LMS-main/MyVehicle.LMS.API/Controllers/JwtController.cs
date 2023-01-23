using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly IJwtService jwtService ;
        public JwtController(IJwtService jwtService  )
        {
            this.jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Authen([FromBody] UsernamePassword usernamePassword)
        {
            var token = jwtService.Auth(usernamePassword);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }

    }
}
