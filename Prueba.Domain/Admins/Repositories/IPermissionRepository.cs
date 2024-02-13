using Prueba.Domain.Admins.Models;
using Jazani.Domain.Cores.Repositories;

namespace Prueba.Domain.Admins.Repositories
{
    public interface IPermissionRepository : ICrudRepository<Permission, int>
    {
    }
}
