using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Admins.Models
{
    public class PermissionLabel
    {
        public int PermissionId { get; set; }
        public int LabelId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
