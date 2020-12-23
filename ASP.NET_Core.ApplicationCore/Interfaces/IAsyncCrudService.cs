using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        Task<TEntity> GetAsync(TPrimaryKey id, string nameOfPrimaryKey);

        Task<IReadOnlyList<TEntity>> GetAllAsync();

        Task<(TEntity, bool)> CreateAsync(TEntity input);

        Task<(TEntity, bool)> UpdateAsync(TEntity input, object modifiedFields, string nameOfPrimaryKey);

        Task<bool> DeleteAsync(TPrimaryKey id, string nameOfPrimaryKey);
    }
}
