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
    public class InsuranceController : ControllerBase
    {

        private readonly IInsuranceService insuranceService;
        public InsuranceController(IInsuranceService insuranceService)
        {
            this.insuranceService = insuranceService;
        }

        [HttpGet]
        [Route("GetAllInsurance")]
        [ProducesResponseType(typeof(List<Insurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Insurance> GetAllInsurance()
        {
            return insuranceService.GetAllInsurance();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Insurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertInsurance([FromBody]Insurance insurance)
        {
            return insuranceService.InsertInsurance(insurance);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Insurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateInsurance(Insurance insurance)
        {
            return insuranceService.UpdateInsurance(insurance);
        }
    }
}
