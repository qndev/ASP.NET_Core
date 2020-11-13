using ASP.NET_Core.ApplicationCore.Dtos;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCreateUpdateInput>
        where TEntity : class
        where TEntityDto : class
        where TCreateUpdateInput : class
    {
        Task<TEntityDto> GetAsync(TPrimaryKey id);

        Task<TEntityDto> CreateAsync(TCreateUpdateInput input);

        Task<TEntityDto> UpdateAsync(TCreateUpdateInput input, TPrimaryKey id);

        Task DeleteAsync(TPrimaryKey id);
    }
}
