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
    public class NewCarLicensingController : ControllerBase
    {
        private readonly INewCarLicensingService newCarLicensingService;
        public NewCarLicensingController(INewCarLicensingService newCarLicensingService)
        {
            this.newCarLicensingService = newCarLicensingService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<NewCarLicensing>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<PaymentValue> InsertNewCarLicensing([FromBody] NewCarLicensing newCarLicensing)
        {
            return newCarLicensingService.InsertNewCarLicensing(newCarLicensing);
        }
    }
}
