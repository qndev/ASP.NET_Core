using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IRepository<T, TPrimaryKey> where T : class
    {
        Task<T> GetByIdAsync(TPrimaryKey id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<(T, bool)> InsertAsync(T entity);
        Task<(T, bool)> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
