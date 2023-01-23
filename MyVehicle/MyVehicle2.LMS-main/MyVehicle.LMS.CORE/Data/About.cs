using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutImage { get; set; }
        public string Description { get; set; }
        public int SettingId { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting{ get; set; }
    }
}
