using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Cards
    {
        [Key]
        public int CardId { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public DateTime CardDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }
    }
}
