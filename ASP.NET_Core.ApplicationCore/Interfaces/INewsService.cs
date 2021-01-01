using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface INewsService<TEntity, TPrimaryKey> where TEntity : class
    {
        Task<TEntity> GetNewsByIdAsync(TPrimaryKey id, string nameOfPrimaryKey, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);
        Task<(TEntity, bool)> CreateNewsAsync(TEntity entity);
        Task<(TEntity, bool)> UpdateNewsAsync(TEntity entity);
        Task<bool> DeleteNewsAsync(TEntity entity);
    }
}
