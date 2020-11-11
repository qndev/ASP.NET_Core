using ASP.NET_Core.ApplicationCore.Dtos;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCrudEntityDto>
        where TEntity : class
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TCrudEntityDto : IEntityDto<TPrimaryKey>
    {
        Task<TEntityDto> GetAsync(TCrudEntityDto input);

        Task<TEntityDto> CreateAsync(TCrudEntityDto input);

        Task<TEntityDto> UpdateAsync(TCrudEntityDto input);

        Task DeleteAsync(TCrudEntityDto input);
    }
}
