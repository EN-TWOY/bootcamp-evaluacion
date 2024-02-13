using Prueba.Domain.Admins.Models;
using Prueba.Domain.Cores.Repositories;

namespace Prueba.Domain.Admins.Repositories
{
    public interface IPermissionRepository : ICrudRepository<Permission, int>
    {
    }
}
