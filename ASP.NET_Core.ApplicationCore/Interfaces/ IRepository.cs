using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IRepository<T, TPrimaryKey> where T : class
    {
        Task<T> GetByIdAsync(TPrimaryKey id, string nameOfPrimaryKey, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<(T, bool)> InsertAsync(T entity);
        Task<(T, bool)> UpdateAsync(T entity);
        Task<(T, bool)> UpdateAsync(T entity, object modifiedFields, string nameOfPrimaryKey);
        Task<(T, bool)> UpdateAsync(T entity, string nameOfPrimaryKey, params Expression<Func<T, object>>[] properties);
        Task<(T, bool)> UpdateAsync(T entity, string nameOfPrimaryKey);
        Task<bool> DeleteAsync(T entity);
    }
}
