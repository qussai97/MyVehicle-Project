using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
  public  class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialEmail { get; set; }
        public int TestimonialTel { get; set; }
        public string Comment { get; set; }
        public string ProblemImage { get; set; }
        public int SettingId { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }
    }
}
