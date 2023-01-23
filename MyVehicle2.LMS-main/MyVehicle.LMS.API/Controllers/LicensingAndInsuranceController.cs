using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
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
    public class LicensingAndInsuranceController : ControllerBase
    {
        private readonly ILicensingAndInsuranceService licensingAndInsuranceService;
        public LicensingAndInsuranceController(ILicensingAndInsuranceService licensingAndInsuranceService)
        {
            this.licensingAndInsuranceService = licensingAndInsuranceService;
        }
     

        [HttpGet]
        [Route("GetAllLicensingAndInsurance")]
        [ProducesResponseType(typeof(List<LicensingAndInsurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<LicensingAndInsurance> GetAllLicensingAndInsurance()
        {
            return licensingAndInsuranceService.GetAllLicensingAndInsurance();
        }


        [HttpPost]
        [ProducesResponseType(typeof(List<LicensingAndInsurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertLicensingAndInsurance([FromBody] LicensingAndInsurance licensingAndInsurance)
        {
            return licensingAndInsuranceService.InsertLicensingAndInsurance(licensingAndInsurance);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<LicensingAndInsurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance)
        {
            return licensingAndInsuranceService.UpdateLicensingAndInsurance(licensingAndInsurance);
        }

        [HttpPost]
        [Route("CreateLicensingAndInsurance")]
        [ProducesResponseType(typeof(List<LicensingAndInsurance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateLicensingAndInsurance([FromBody]LicensingInsurance licensingInsurance)
        {
            return licensingAndInsuranceService.CreateLicensingAndInsurance(licensingInsurance);
        }
    }
}
