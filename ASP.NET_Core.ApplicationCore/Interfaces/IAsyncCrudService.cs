using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        Task<TEntity> GetAsync(TPrimaryKey id, string nameOfPrimaryKey);

        Task<IReadOnlyList<TEntity>> GetAllAsync();

        Task<(TEntity, bool)> CreateAsync(TEntity input);

        Task<(TEntity, bool)> UpdateAsync(TEntity input);

        Task<(TEntity, bool)> UpdateAsync(TEntity input, object modifiedFields, string nameOfPrimaryKey);

        Task<(TEntity, bool)> UpdateAsync(TEntity input, string nameOfPrimaryKey, params Expression<Func<TEntity, object>>[] properties);

        Task<(TEntity, bool)> UpdateAsync(TEntity input, string nameOfPrimaryKey);

        Task<bool> DeleteAsync(TPrimaryKey id, string nameOfPrimaryKey);
    }
}
