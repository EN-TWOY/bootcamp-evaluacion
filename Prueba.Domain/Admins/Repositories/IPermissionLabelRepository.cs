using Jazani.Domain.Cores.Repositories;
using Prueba.Domain.Admins.Models;

namespace Prueba.Domain.Admins.Repositories
{
    public interface IPermissionLabelRepository : ICrudRepository<PermissionLabel, int>
    {
    }
}
