namespace ASP.NET_Core.ApplicationCore.Dtos
{
    public interface IEntityDto : IEntityDto<int>
    {
    }

    public interface IEntityDto<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
