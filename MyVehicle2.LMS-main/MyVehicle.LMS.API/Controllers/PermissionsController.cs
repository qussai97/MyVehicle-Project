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
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionsService permissionsService;
        public PermissionsController(IPermissionsService permissionsService)
        {
            this.permissionsService = permissionsService;
        }
        [HttpPost]
        [Route("InsertPermissions")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertPermissions(int RoleId)
        {
            return permissionsService.InsertPermissions(RoleId);
        }
        [HttpPut]
        [Route("UpdatePermissions")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdatePermissions(Permissions Per)
        {
            return permissionsService.UpdatePermissions(Per);
        }

        [HttpDelete]
        [Route("DeletePermissions")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeletePermissions(int PermissionsId)
        {
            return permissionsService.DeletePermissions(PermissionsId);
        }

        [HttpGet]
        [Route("GetAllPermissions")]
        [ProducesResponseType(typeof(List<Permissions>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Permissions> GetAllPermissions()
        {
            return permissionsService.GetAllPermissions();
        }
    }
}
