using PostoGasolina.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PostoGasolina.Entity
{
    public interface IRepositoryBase<TEntity> where TEntity : GeraId
    {
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> ObterPorIdAsync(Guid id);
        Task AddAsync(TEntity GeraId);
        Task DeletarAsync(TEntity GeraId);
        Task Atualizar(TEntity GeraId);


    }
}
