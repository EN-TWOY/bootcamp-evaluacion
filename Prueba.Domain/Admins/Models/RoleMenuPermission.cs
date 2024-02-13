using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Admins.Models
{
    public class RoleMenuPermission
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public int PermissionId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
