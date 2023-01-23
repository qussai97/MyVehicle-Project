using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
     public class ImagesService: IImagesService
    {
        private readonly IImagesRepository imagesRepoisitory;
        public ImagesService(IImagesRepository imagesRepoisitory)
        {
            this.imagesRepoisitory = imagesRepoisitory;
        }

        public bool DeleteImages(Images images)
        {
            return imagesRepoisitory.DeleteImages(images);
        }

        public List<Images> GetAllImages()
        {
            return imagesRepoisitory.GetAllImages();
        }

        public Images GetImagesById(Images images)
        {
            return imagesRepoisitory.GetImagesById(images);
        }

        public bool InsertImages(Images images)
        {
            return imagesRepoisitory.InsertImages(images);
        }

        public bool UpdateImages(Images images)
        {
            return imagesRepoisitory.UpdateImages(images);
        }
    }
}
