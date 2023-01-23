using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class BankCard
    {
        [Key]
        public int BankCardId { get; set; }
        public string BankNumber { get; set; }
        public string BankName { get; set; }
        public DateTime BankDate { get; set; }
        public double BankAmount { get; set; }
        public string BankPassword { get; set; }
        public int SettingId { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }
    }
}
