using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Permissions> Permissions { get; set; }
        public ICollection<Report> Reports { get; set; }
        
        public ICollection<Login> Logins { get; set; }

    }
}
