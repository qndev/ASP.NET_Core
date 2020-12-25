using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IRepository<T, TPrimaryKey> where T : class
    {
        Task<T> GetByIdAsync(TPrimaryKey id, string nameOfPrimaryKey);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<(T, bool)> InsertAsync(T entity);
        Task<(T, bool)> UpdateAsync(T entity);
        Task<(T, bool)> UpdateAsync(T entity, object modifiedFields, string nameOfPrimaryKey);
        Task<(T, bool)> UpdateAsync(T entity, string nameOfPrimaryKey, params Expression<Func<T, object>>[] properties);
        Task<(T, bool)> UpdateAsync(T entity, string nameOfPrimaryKey);
        Task<bool> DeleteAsync(T entity);
    }
}
