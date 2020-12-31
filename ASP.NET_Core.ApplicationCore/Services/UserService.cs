using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class UserService<TEntity, TPrimaryKey> : IUserService<TEntity, TPrimaryKey>
        where TEntity : class
    {
        private readonly IRepository<TEntity, TPrimaryKey> _userRepository;

        public UserService(IRepository<TEntity, TPrimaryKey> userRepository)
        {
            _userRepository = userRepository;
        }

        public virtual async Task<TEntity> GetUserByIdAsync(TPrimaryKey userId, string nameOfEntityKey)
        {
            return await _userRepository.GetByIdAsync(userId, nameOfEntityKey);
        }

        public virtual async Task<(TEntity, bool)> CreateUserAsync(TEntity user)
        {
            return await _userRepository.InsertAsync(user);
        }

        public virtual async Task<(TEntity, bool)> UpdateUserAsync(TEntity user)
        {
            return await _userRepository.UpdateAsync(user);
        }

        public virtual async Task<bool> DeleteUserAsync(TEntity user)
        {
            return await _userRepository.DeleteAsync(user);
        }
    }
}
