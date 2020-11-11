using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Dtos;
using ASP.NET_Core.ApplicationCore.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class AsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCrudEntityDto> : CrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TCrudEntityDto>, IAsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCrudEntityDto>
        where TEntity : class
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TCrudEntityDto : IEntityDto<TPrimaryKey>
    {
        protected AsyncCrudService(IRepository<TEntity, TPrimaryKey> repository, IMapper mapper)
            :base(repository, mapper)
        {
        }
        public virtual async Task<TEntityDto> GetAsync(TCrudEntityDto input)
        {
            var entity = await GetEntityByIdAsync(input.Id);
            //return _mapper.Map<TEntity, TEntityDto>(entity);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> CreateAsync(TCrudEntityDto input)
        {
            var entity = MapToEntity(input);
            await _repository.InsertAsync(entity);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> UpdateAsync(TCrudEntityDto input)
        {
            var entity = await GetEntityByIdAsync(input.Id);
            MapToEntity(input, entity);
            await _repository.UpdateAsync(entity);
            return MapToEntityDto(entity);
        }

        public virtual async Task DeleteAsync(TCrudEntityDto input)
        {
            var entity = await GetEntityByIdAsync(input.Id);
            await _repository.DeleteAsync(entity);
        }

        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id)
        {
             return _repository.GetByIdAsync(id);
        }
    }
}
