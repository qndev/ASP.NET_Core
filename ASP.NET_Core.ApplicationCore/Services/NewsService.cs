using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class NewsService<TEntity, TPrimaryKey> : INewsService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        private readonly IRepository<TEntity, TPrimaryKey> _newsRepository;

        public NewsService(IRepository<TEntity, TPrimaryKey> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public virtual async Task<TEntity> GetNewsByIdAsync(TPrimaryKey userId, string nameOfEntityKey)
        {
            return await _newsRepository.GetByIdAsync(userId, nameOfEntityKey);
        }

        public virtual async Task<(TEntity, bool)> CreateNewsAsync(TEntity news)
        {
            return await _newsRepository.InsertAsync(news);
        }

        public virtual async Task<(TEntity, bool)> UpdateNewsAsync(TEntity news)
        {
            return await _newsRepository.UpdateAsync(news);
        }

        public virtual async Task<bool> DeleteNewsAsync(TEntity news)
        {
            return await _newsRepository.DeleteAsync(news);
        }
    }
}
