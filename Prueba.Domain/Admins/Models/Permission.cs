using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Admins.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public string Slug { get; set; } = default!;
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

        public virtual ICollection<RoleMenuPermission> RoleMenuPermissions { get; set; }
    }
}
