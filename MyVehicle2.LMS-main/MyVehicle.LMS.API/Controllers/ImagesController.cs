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
    public class ImagesController : ControllerBase
    {
        private readonly IImagesService imagesService;
        public ImagesController(IImagesService imagesService)
        {
            this.imagesService = imagesService;
        }
        [HttpDelete("delete")]
        [ProducesResponseType(typeof(List<Images>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteImages(Images images)
        {
            return imagesService.DeleteImages(images);
        }

        [HttpGet]
        [Route("GetAllImages")]
        [ProducesResponseType(typeof(List<Images>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Images> GetAllImages()
        {
            return imagesService.GetAllImages();
        }


        [HttpPost]
        [ProducesResponseType(typeof(List<Images>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertImages([FromBody] Images images)
        {
            return imagesService.InsertImages(images);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Images>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateImages(Images images)
        {
            return imagesService.UpdateImages(images);
        }
        [HttpGet]
        [Route("GetImageById")]
        [ProducesResponseType(typeof(List<Images>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Images GetImagesById(Images images)
        {
            return imagesService.GetImagesById(images);
        }
    }
}
