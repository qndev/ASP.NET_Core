using ASP.NET_Core.ApplicationCore.Dtos;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        Task<TEntity> GetAsync(TPrimaryKey id);

        Task<(TEntity, bool)> CreateAsync(TEntity input);

        Task<(TEntity, bool)> UpdateAsync(TEntity input, TPrimaryKey id);

        Task<bool> DeleteAsync(TPrimaryKey id);
    }
}
