using System.Threading.Tasks;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IUserService<TEntity, TPrimaryKey> where TEntity : class
    {
        Task<TEntity> GetUserByIdAsync(TPrimaryKey id, string nameOfPrimaryKey);
        Task<(TEntity, bool)> CreateUserAsync(TEntity entity);
        Task<(TEntity, bool)> UpdateUserAsync(TEntity entity);
        Task<bool> DeleteUserAsync(TEntity entity);
    }
}
