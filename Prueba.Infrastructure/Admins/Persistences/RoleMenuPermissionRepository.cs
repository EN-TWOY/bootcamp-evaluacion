using Prueba.Infrastructure.Cores.Persistences;
using Prueba.Domain.Admins.Models;
using Prueba.Domain.Admins.Repositories;
using Prueba.Infrastructure.Cores.Contexts;

namespace Prueba.Infrastructure.Admins.Persistences
{
    public class RoleMenuPermissionRepository : CrudRepository<Permission, int>, IPermissionRepository
    {
        public RoleMenuPermissionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
