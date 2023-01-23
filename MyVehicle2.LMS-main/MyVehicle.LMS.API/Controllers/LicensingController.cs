using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
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
    public class LicensingController : ControllerBase
    {
        private readonly ILicensingService licensingService ;
        public LicensingController(ILicensingService licensingService)
        {
            this.licensingService = licensingService;
        }

        [HttpGet]
        [Route("GetAllLicensing")]
        [ProducesResponseType(typeof(List<Licensing>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Licensing> GetAllLicensing()
        {
            return licensingService.GetAllLicensing();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Licensing>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertLicensing([FromBody]Licensing licensing)
        {
            return licensingService.InsertLicensing(licensing);
        }


        [HttpPut]        
        [ProducesResponseType(typeof(List<Licensing>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateLicensing(Licensing licensing)
        {
            return licensingService.UpdateLicensing(licensing);
        }
        [HttpPost]
        [Route("SearchLicensingCost")]

        [ProducesResponseType(typeof(List<PaymentCost>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public PaymentCost SearchLicensingCost([FromBody] SearchLicensingCostByEngineCapasty searchLicensingCostByEngineCapasty)
        {
            return licensingService.SearchLicensingCost(searchLicensingCostByEngineCapasty);
        }

        [HttpPost]
        [Route("SearchInfo")]

        [ProducesResponseType(typeof(List<GetCost>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public GetCost SearchInfo([FromBody]EngineCapacityAndType capacityAndType)
        {
            return licensingService.SearchInfo(capacityAndType);
        }

    }
}
