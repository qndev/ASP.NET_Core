using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class AsyncCrudService<TEntity, TPrimaryKey> : IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        private readonly IRepository<TEntity, TPrimaryKey> _repository;

        public AsyncCrudService(
            IRepository<TEntity, TPrimaryKey> repository
        )
        {
            _repository = repository;
        }
        public virtual async Task<TEntity> GetAsync(TPrimaryKey id)
        {
            var entity = await GetEntityByIdAsync(id);
            return entity;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity input)
        {
            return await _repository.InsertAsync(input);
        }

        public virtual async Task UpdateAsync(TEntity input, TPrimaryKey id)
        {
            var entity = await GetEntityByIdAsync(id);
            await _repository.UpdateAsync(input);
        }

        public virtual async Task DeleteAsync(TPrimaryKey id)
        {
            var entity = await GetEntityByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }

        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id)
        {
            return _repository.GetByIdAsync(id);
        }
    }
}
