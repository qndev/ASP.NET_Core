namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public interface IEntity : IEntity<int>
    {
    }

     public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
