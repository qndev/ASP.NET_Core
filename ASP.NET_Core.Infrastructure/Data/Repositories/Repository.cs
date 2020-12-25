using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;
using Microsoft.Extensions.Logging;
using System.Reflection;
using ASP.NET_Core.ApplicationCore.Extensions;
using System.Linq.Expressions;

namespace ASP.NET_Core.Infrastructure.Data.Repositories
{
    public class Repository<T, TPrimaryKey> : IRepository<T, TPrimaryKey>
        where T : class
        where TPrimaryKey : IEquatable<TPrimaryKey>
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

        public virtual async Task<T> GetByIdAsync(TPrimaryKey id, string nameOfEntityKey)
        {
            // IEnumerable<Faq> allPeople = _dbContext.Faqs.Where(p => p.Answer.StartsWith("N"));
            // IQueryable<Faq> enumerablePeople = allPeople;
            // var allPeople = _dbContext.Faqs.Where(p => p.Answer.StartsWith("N"));
            // IEnumerable<Faq> activePeople = allPeople.Where(p => p.Id == 1);
            var predicate = QueryableExtensions.EntityIdComparison<T, TPrimaryKey>(id, nameOfEntityKey);

            _logger.LogInformation(predicate.ToString());
            // return await _dbSet.FirstOrDefaultAsync(predicate);
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
            // return await _dbSet.FindAsync(id);
        }

        public virtual async Task<T> FirstOrDefaultAsync(TPrimaryKey id, string primaryKey)
        {
            // var allPeople = _dbContext.Faqs.Where(p => p.Answer.StartsWith("N"));
            // IEnumerable<Faq> enumerablePeople = allPeople;
            // var activePeople = enumerablePeople.Where(p => p.Id == 1);
            return await _dbSet.FirstOrDefaultAsync(typeOfT => typeOfT.GetType().GetProperty(primaryKey).Name.Equals(id));
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
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
            var entityKeyName = GetEntityKeyName(entity);
            var entityKeyValue = GetEntityKeyValue(entity, entityKeyName);
            var existingEntity = await GetByIdAsync(entityKeyValue, entityKeyName);
            if (existingEntity == null)
            {
                _logger.LogInformation("Notfound Entity.");
                return (entity, false);
            }
            _logger.LogInformation("State of Existing Entity: " + _dbContext.Entry(existingEntity).State.ToString());
            _logger.LogInformation("State of Entity Before SetModified: " + _dbContext.Entry(entity).State.ToString());
            this.SetModifiedEntityState(entity, entityKeyName);
            _logger.LogInformation("State of Entity After SetModified: " + _dbContext.Entry(entity).State.ToString());
            return (entity, await CommitSaveChangesAsync());
        }

        public virtual async Task<(T, bool)> UpdateAsync(T entity, object modifiedFields, string nameOfEntityKey)
        {
            var entityKeyValue = GetEntityKeyValue(entity, nameOfEntityKey);
            // get entity with tracking
            var existingEntity = await GetByIdAsync(entityKeyValue, nameOfEntityKey);
            if (existingEntity == null)
            {
                _logger.LogInformation("Notfound Entity.");
                return (entity, false);
            }
            // _dbContext.Update(entity);
            // _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(modifiedFields);
            return (entity, await CommitSaveChangesAsync());
        }

        public virtual async Task<(T, bool)> UpdateAsync(T entity, string nameOfEntityKey, params Expression<Func<T, object>>[] properties)
        {
            var entityKeyValue = GetEntityKeyValue(entity, nameOfEntityKey);
            // get entity without tracking: AsNoTracking()
            var existingEntity = await GetByIdAsync(entityKeyValue, nameOfEntityKey);
            if (existingEntity == null)
            {
                _logger.LogInformation("Notfound Entity.");
                return (entity, false);
            }
            // uncomment here when existingEntity with state is tracking
            // _dbContext.Entry(entity).State = EntityState.Unchanged;
            foreach (var property in properties)
            {
                var propertyName = GetPropertyName(property);
                _dbContext.Entry(entity).Property(propertyName).IsModified = true;
            }
            return (entity, await CommitSaveChangesAsync());
        }

        public virtual async Task<(T, bool)> UpdateAsync(T entity, string nameOfEntityKey)
        {
            var entityKeyValue = GetEntityKeyValue(entity, nameOfEntityKey);
            // get entity without tracking: AsNoTracking()
            var existingEntity = await GetByIdAsync(entityKeyValue, nameOfEntityKey);
            if (existingEntity == null)
            {
                _logger.LogInformation("Notfound Entity.");
                return (entity, false);
            }
            PropertyInfo[] entityProperties = entity.GetType().GetProperties();
            foreach (var entityProperty in entityProperties)
            {
                _logger.LogInformation(entityProperty.Name);
                if ((entityProperty.Name != nameOfEntityKey) && (entityProperty.GetValue(entity) != null))
                {
                    _dbContext.Entry(entity).Property(entityProperty.Name).IsModified = true;
                }
            }
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
                Console.WriteLine("Something went wrong." + ex);
                return false;
            }
        }

        #region Helpers

        private string GetEntityKeyName(T entity)
        {
            var entityProperties = _dbContext.Entry(entity).Metadata.GetProperties();
            foreach (var entityProperty in entityProperties)
            {
                if (entityProperty.IsPrimaryKey())
                {
                    var entityKeyName = entityProperty.GetColumnName();
                    _logger.LogInformation(entityKeyName);
                    return entityKeyName;
                }
            };
            return null;
        }

        private TPrimaryKey GetEntityKeyValue(T entity, string nameOfEntityKey)
        {
            PropertyInfo propertyInfo = entity.GetType().GetProperty(nameOfEntityKey);
            var entityKeyValue = propertyInfo.GetValue(entity);
            return (TPrimaryKey)Convert.ChangeType(entityKeyValue, typeof(TPrimaryKey));
        }

        private string GetPropertyName(Expression<Func<T, object>> propertyExpression)
        {
            MemberExpression memberExpression = propertyExpression.Body as MemberExpression;
            _logger.LogInformation(memberExpression.Member.Name);
            return memberExpression.Member.Name;
        }

        // private string GetPropertyOfEntity(T entity)
        // {
        //     return "";
        // }

        private T SetModifiedEntityState(T entity, string entityKeyName)
        {
            PropertyInfo[] entityProperties = entity.GetType().GetProperties();
            foreach (var entityProperty in entityProperties)
            {
                _logger.LogInformation(entityProperty.Name);
                if ((entityProperty.Name != entityKeyName) && (entityProperty.GetValue(entity) != null))
                {
                    _dbContext.Entry(entity).Property(entityProperty.Name).IsModified = true;
                }
            }
            return entity;
        }

        #endregion
    }
}
