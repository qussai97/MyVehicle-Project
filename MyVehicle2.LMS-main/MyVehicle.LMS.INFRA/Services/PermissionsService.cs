using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class PermissionsService: IPermissionsService
    {
        private readonly IPermissionsRepoisitory permissionsRepoisitory;
        public PermissionsService(IPermissionsRepoisitory permissionsRepoisitory)
        {
            this.permissionsRepoisitory = permissionsRepoisitory;
        }

        public bool DeletePermissions(int PermissionsId)
        {
            return permissionsRepoisitory.DeletePermissions(PermissionsId);
        }

        public List<Permissions> GetAllPermissions()
        {
            return permissionsRepoisitory.GetAllPermissions();
        }

        public bool InsertPermissions(int RoleId)
        {
            return permissionsRepoisitory.InsertPermissions(RoleId);
        }

        public bool UpdatePermissions(Permissions Per)
        {
            return permissionsRepoisitory.UpdatePermissions(Per);
        }
    }
}
