using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IImagesRepository
    {
        public bool InsertImages(Images images);
        public bool UpdateImages(Images images);
        public bool DeleteImages(Images images);
        public List<Images> GetAllImages();
        public Images GetImagesById(Images images);

    }
}
