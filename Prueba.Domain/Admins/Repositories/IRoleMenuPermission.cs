using Prueba.Domain.Cores.Repositories;
using Prueba.Domain.Admins.Models;

namespace Prueba.Domain.Admins.Repositories
{
    public interface IRoleMenuPermission : ICrudRepository<RoleMenuPermission, int>
    {
    }
}
