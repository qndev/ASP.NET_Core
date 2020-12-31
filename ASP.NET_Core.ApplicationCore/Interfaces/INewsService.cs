using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface INewsService<TEntity, TPrimaryKey> where TEntity : class
    {
        Task<TEntity> GetNewsByIdAsync(TPrimaryKey id, string nameOfPrimaryKey);
        Task<(TEntity, bool)> CreateNewsAsync(TEntity entity);
        Task<(TEntity, bool)> UpdateNewsAsync(TEntity entity);
        Task<bool> DeleteNewsAsync(TEntity entity);
    }
}
