using Prueba.Domain.Cores.Repositories;
using Prueba.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Prueba.Infrastructure.Cores.Persistences
{
    public abstract class CrudRepository<TEntity, ID> : ICrudRepository<TEntity, ID> where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;

        public CrudRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IReadOnlyList<TEntity>> FindAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public Task<IReadOnlyList<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate, List<Expression<Func<TEntity, object>>> includes = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, List<Expression<Func<TEntity, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity?> FindByIdAsync(ID id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<TEntity> SaveAsync(TEntity entity)
        {
            EntityState entityState = _dbContext.Entry(entity).State;

            _ = entityState switch
            {
                EntityState.Detached => _dbContext.Set<TEntity>().Add(entity),
                EntityState.Modified => _dbContext.Set<TEntity>().Update(entity)
            };


            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}

