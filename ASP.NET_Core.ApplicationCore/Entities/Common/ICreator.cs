namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public interface ICreator
    {
        int CreatedBy { get; set; }
        int ModifiedBy { get; set; }
    }
}
