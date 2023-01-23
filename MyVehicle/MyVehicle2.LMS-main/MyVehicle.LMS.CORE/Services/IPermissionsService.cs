using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface IPermissionsService
    {
        public bool InsertPermissions(int RoleId);
        public bool UpdatePermissions(Permissions Per);
        public bool DeletePermissions(int PermissionsId);
        public List<Permissions> GetAllPermissions();
    }
}
