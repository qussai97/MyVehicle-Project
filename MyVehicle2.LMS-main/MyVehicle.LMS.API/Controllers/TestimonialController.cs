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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }
        [HttpDelete("DeleteTestimonial/{TestimonialId}")]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteTestimonial(int TestimonialId)
        {
            return testimonialService.DeleteTestimonial(TestimonialId);
        }

        [HttpGet]
        [Route("GetAllTestimonial")]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Testimonial> GetAllTestimonial()
        {
            return testimonialService.GetAllTestimonial();
        }


        [HttpPost]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertTestimonial([FromBody] Testimonial testimonial)
        {
            return testimonialService.InsertTestimonial(testimonial);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTestimonial(Testimonial testimonial)
        {
            return testimonialService.UpdateTestimonial(testimonial);
        }
    }
}
