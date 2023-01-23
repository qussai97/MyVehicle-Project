using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
  public   class Images
    {
        [Key]
        public int ImagesId { get; set; }
        public string ImageName { get; set; }
       
        public int SettingId { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }
    }
}
