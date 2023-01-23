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
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteContact(int id)
        {
            return contactService.DeleteContact(id);
        }
        [HttpGet]
        [Route("GetAllContact")]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Contact> GetAllContact()
        {
            return contactService.GetAllContact();
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertContact([FromBody] Contact contact)
        {
            return contactService.InsertContact(contact);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateContact([FromBody] Contact contact)
        {
            return contactService.UpdateContact(contact);
        }
    }
}
