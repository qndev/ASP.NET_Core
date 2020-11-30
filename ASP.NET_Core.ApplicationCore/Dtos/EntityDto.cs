using System;

namespace ASP.NET_Core.ApplicationCore.Dtos
{
    [Serializable]
    public class EntityDto : EntityDto<int>, IEntityDto
    {
        public EntityDto()
        {
        }

        public EntityDto(int id)
            : base(id)
        {
        }
    }

    [Serializable]
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }

        public EntityDto()
        {
        }

        public EntityDto(TPrimaryKey id)
        {
            Id = id;
        }
    }
}
