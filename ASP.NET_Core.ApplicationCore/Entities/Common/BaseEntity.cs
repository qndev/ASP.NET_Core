namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public abstract class BaseEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
