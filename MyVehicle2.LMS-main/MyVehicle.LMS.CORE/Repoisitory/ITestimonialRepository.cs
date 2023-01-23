using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
     public interface ITestimonialRepository
    {
        public bool DeleteTestimonial(int TestimonialId);
        public List<Testimonial> GetAllTestimonial();
        public bool InsertTestimonial(Testimonial testimonial);
        public bool UpdateTestimonial(Testimonial testimonial);
    }
}
