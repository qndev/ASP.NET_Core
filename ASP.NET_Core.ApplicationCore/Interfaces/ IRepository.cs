using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IRepository<T, TPrimaryKey> where T : class
    {
        Task<T> GetByIdAsync(TPrimaryKey id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
