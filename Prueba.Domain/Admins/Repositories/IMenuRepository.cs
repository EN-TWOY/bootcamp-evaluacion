using Prueba.Domain.Admins.Models;
using Jazani.Domain.Cores.Repositories;

namespace Prueba.Domain.Admins.Repositories
{
    public interface IMenuRepository : ICrudRepository<Menu, int>
    {
    }
}
