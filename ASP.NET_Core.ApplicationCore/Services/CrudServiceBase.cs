using ASP.NET_Core.ApplicationCore.Dtos;
using ASP.NET_Core.ApplicationCore.Interfaces;
using AutoMapper;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class CrudServiceBase<TEntity, TEntityDto, TPrimaryKey, TCreateUpdateInput>
        where TEntity : class
        where TEntityDto : class
        where TCreateUpdateInput : class
    {
        private readonly IMapper _mapper;
        protected readonly IRepository<TEntity, TPrimaryKey> _repository;

        public CrudServiceBase(
            IRepository<TEntity, TPrimaryKey> repository
        )
        {
            _repository = repository;
        }

        public CrudServiceBase(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected virtual TEntity MapToEntity(TCreateUpdateInput createInput)
        {
            return _mapper.Map<TEntity>(createInput);
        }
        protected virtual void MapToEntity(TCreateUpdateInput updateInput, TEntity entity)
        {
            _mapper.Map(updateInput, entity);
        }
        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            return _mapper.Map<TEntityDto>(entity);
        }
    }
}
