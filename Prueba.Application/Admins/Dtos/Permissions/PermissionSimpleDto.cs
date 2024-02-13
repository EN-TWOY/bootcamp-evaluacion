using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Admins.Dtos.Permissions
{
    public class PermissionSimpleDto
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
