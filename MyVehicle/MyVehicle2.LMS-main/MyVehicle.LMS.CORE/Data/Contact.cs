using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public int PhoneNumber1 { get; set; }
        public int PhoneNumber2 { get; set; }
        public int SettingId { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }
    }
}
