using ASP.NET_Core.ApplicationCore.Dtos;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        Task<TEntity> GetAsync(TPrimaryKey id);

        Task<(TEntity, bool)> CreateAsync(TEntity input);

        Task UpdateAsync(TEntity input, TPrimaryKey id);

        Task DeleteAsync(TPrimaryKey id);
    }
}
