using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IAboutRepository
    {
        public bool InsertAbout(About about);
        public bool UpdateAbout(About about);
        public bool DeleteAbout(int id);
        public List<About> GetAllAbout();
    }
}
