using System;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class AsyncCrudService<TEntity, TPrimaryKey> : IAsyncCrudService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        protected readonly IRepository<TEntity, TPrimaryKey> _repository;

        public AsyncCrudService(
            IRepository<TEntity, TPrimaryKey> repository
        )
        {
            _repository = repository;
        }
        public virtual async Task<TEntity> GetAsync(TPrimaryKey id, string nameOfPrimaryKey)
        {
            var entity = await GetEntityByIdAsync(id, nameOfPrimaryKey);
            return entity;
        }

        public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<(TEntity, bool)> CreateAsync(TEntity input)
        {
            return await _repository.InsertAsync(input);
        }

        public virtual async Task<(TEntity, bool)> UpdateAsync(TEntity input, object modifiedFields, string nameOfPrimaryKey)
        {
            return await _repository.UpdateAsync(input, modifiedFields, nameOfPrimaryKey);
        }

        public virtual async Task<(TEntity, bool)> UpdateAsync(TEntity input, string nameOfPrimaryKey,  params Expression<Func<TEntity, object>>[] properties)
        {
            return await _repository.UpdateAsync(input, nameOfPrimaryKey, properties);
        }

        public virtual async Task<(TEntity, bool)> UpdateAsync(TEntity input, string nameOfPrimaryKey)
        {
            return await _repository.UpdateAsync(input, nameOfPrimaryKey);
        }

        public virtual async Task<bool> DeleteAsync(TPrimaryKey id, string nameOfPrimaryKey)
        {
            var entity = await GetEntityByIdAsync(id, nameOfPrimaryKey);
            if (entity != null)
            {
                return await _repository.DeleteAsync(entity);
            }
            return false;
        }

        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id, string nameOfPrimaryKey)
        {
            return _repository.GetByIdAsync(id, nameOfPrimaryKey);
        }
    }
}
