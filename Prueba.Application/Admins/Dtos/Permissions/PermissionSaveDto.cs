using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Admins.Dtos.Permissions
{
    public class PermissionSaveDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public string Slug { get; set; } = default!;
    }
}
