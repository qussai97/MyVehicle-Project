using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class WebsiteSetting
    {
        [Key]
        public int SettingId { get; set; }
        public string WebName { get; set; }
        public string WebLogo { get; set; }
        public string WebBackground { get; set; }

        public ICollection<About> Abouts { get; set; }

        public ICollection<BankCard> BankCards { get; set; }
        public ICollection<Contact> Contacts { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<Images> Images { get; set; }
    }
}
