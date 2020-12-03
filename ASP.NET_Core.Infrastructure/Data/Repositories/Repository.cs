using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.Infrastructure.Data.Repositories
{
    public class Repository<T, TPrimaryKey> : IRepository<T, TPrimaryKey> where T : BaseEntity<int>
    {
        protected readonly InfrastructureContext _dbContext;
        protected DbSet<T> _dbSet;
        private readonly ILogger _logger;

        public Repository(InfrastructureContext dbContext, ILogger<Repository<T, TPrimaryKey>> logger)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
            _logger = logger;
        }

        public virtual async Task<T> GetByIdAsync(TPrimaryKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<(T, bool)> InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return (entity, await CommitSaveChangesAsync());
        }

        public virtual async Task<(T, bool)> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return (entity, await CommitSaveChangesAsync());
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return await CommitSaveChangesAsync();
        }

        public async Task<bool> CommitSaveChangesAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Something went wrong." + ex.Message);
                return false;
            }
        }
    }
}
