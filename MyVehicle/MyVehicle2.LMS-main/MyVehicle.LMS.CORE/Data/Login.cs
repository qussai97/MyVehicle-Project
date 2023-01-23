using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
    public class Login
    {
        [Key] 
        public int loginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        

        

        [ForeignKey("RoleId")]

        public virtual Role Role { get; set; }

        public ICollection<Users> Users { get; set; }

    }
}
