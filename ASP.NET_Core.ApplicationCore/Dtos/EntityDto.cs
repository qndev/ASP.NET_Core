
namespace ASP.NET_Core.ApplicationCore.Dtos
{
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
