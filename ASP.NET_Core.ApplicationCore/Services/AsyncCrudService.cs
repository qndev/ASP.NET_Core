using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Dtos;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class AsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCreateUpdateInput> : CrudServiceBase<TEntity, TEntityDto, TPrimaryKey, TCreateUpdateInput>, IAsyncCrudService<TEntity, TEntityDto, TPrimaryKey, TCreateUpdateInput>
        where TEntity : class
        where TEntityDto : class
        where TCreateUpdateInput : class
    {
        protected AsyncCrudService(IRepository<TEntity, TPrimaryKey> repository)
            :base(repository)
        {
        }
        public virtual async Task<TEntityDto> GetAsync(TPrimaryKey id)
        {
            var entity = await GetEntityByIdAsync(id);
            //return _mapper.Map<TEntity, TEntityDto>(entity);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> CreateAsync(TCreateUpdateInput input)
        {
            var entity = MapToEntity(input);
            await _repository.InsertAsync(entity);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> UpdateAsync(TCreateUpdateInput input, TPrimaryKey id)
        {
            var entity = await GetEntityByIdAsync(id);
            MapToEntity(input, entity);
            await _repository.UpdateAsync(entity);
            return MapToEntityDto(entity);
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
