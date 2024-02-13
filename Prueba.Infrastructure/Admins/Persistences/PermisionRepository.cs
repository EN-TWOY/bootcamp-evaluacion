using Prueba.Infrastructure.Cores.Persistences;
using Prueba.Domain.Admins.Models;
using Prueba.Domain.Admins.Repositories;
using Prueba.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Infrastructure.Admins.Persistences
{
    /*
    public class PermisionRepository : CrudRepository<Permission, int>, IPermissionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PermisionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async override Task<Permission?> FindByIdAsync(int id)
        {
            return await _dbContext.Set<Permission>()
                .AsQueryable()
                .Include(t => t.Id)
                .FirstOrDefaultAsync(x => x.Id == id);

        }
    }
    */
}

