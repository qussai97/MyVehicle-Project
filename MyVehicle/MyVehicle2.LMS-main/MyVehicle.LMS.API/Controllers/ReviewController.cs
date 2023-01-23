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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewServiice reviewService;
        public ReviewController(IReviewServiice reviewService)
        {
            this.reviewService = reviewService;
        }
        [HttpPost]
        [Route("InsertReview")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertReview([FromBody] Review Rev)
        {
            return reviewService.InsertReview(Rev);
        }
        [HttpPut]
        [Route("UpdateReview")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateReview(Review Rev)
        {
            return reviewService.UpdateReview(Rev);
        }
    }
}
 