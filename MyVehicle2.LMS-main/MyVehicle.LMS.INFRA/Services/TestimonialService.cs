using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class TestimonialService: ITestimonialService
    {
        private readonly ITestimonialRepository testimonialRepository;
        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }

        public bool DeleteTestimonial(int TestimonialId)
        {
            return testimonialRepository.DeleteTestimonial(TestimonialId);
        }

        public List<Testimonial> GetAllTestimonial()
        {
            return testimonialRepository.GetAllTestimonial();
        }

        public bool InsertTestimonial(Testimonial testimonial)
        {
            return testimonialRepository.InsertTestimonial(testimonial);
        }

        public bool UpdateTestimonial(Testimonial testimonial)
        {
            return testimonialRepository.UpdateTestimonial(testimonial);
        }
    }
}
