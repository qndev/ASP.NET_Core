using ASP.NET_Core.ApplicationCore.Dtos;
using ASP.NET_Core.ApplicationCore.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public abstract class CrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TCrudEntityDto>
        where TEntity : class
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TCrudEntityDto : IEntityDto<TPrimaryKey>
    {
        protected readonly IMapper _mapper;
        protected readonly IRepository<TEntity, TPrimaryKey> _repository;

        public CrudAppServiceBase(
            IRepository<TEntity, TPrimaryKey> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        protected virtual TEntity MapToEntity(TCrudEntityDto createInput)
        {
            return _mapper.Map<TEntity>(createInput);
        }
        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            return _mapper.Map<TEntityDto>(entity);
        }
         protected virtual void MapToEntity(TCrudEntityDto updateInput, TEntity entity)
        {
            _mapper.Map(updateInput, entity);
        }
    }
}
