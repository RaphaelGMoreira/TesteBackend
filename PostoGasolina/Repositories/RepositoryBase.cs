using Microsoft.EntityFrameworkCore;
using PostoGasolina.Contex;
using PostoGasolina.Entity;
using PostoGasolina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PostoGasolina.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : GeraId
    {
        public readonly DbSet<TEntity> _DbSet;
        public readonly PostoContext _AppDbContext;

        public RepositoryBase(PostoContext appContext)
        {
            _DbSet = appContext.Set<TEntity>();
            _AppDbContext = appContext;
        }

        public async Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _DbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<TEntity> ObterPorIdAsync(Guid id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity GeraId)
        {
            await _DbSet.AddAsync(GeraId);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task DeletarAsync(TEntity GeraId)
        {
            _DbSet.Remove(GeraId);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task Atualizar(TEntity GeraId)
        {
            _DbSet.Update(GeraId);
            await _AppDbContext.SaveChangesAsync();
        }
    }
}
