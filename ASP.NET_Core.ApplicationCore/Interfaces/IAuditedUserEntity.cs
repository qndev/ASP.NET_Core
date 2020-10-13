namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAuditedUserEntity {
        int CreatedBy { get; set; }
        int ModifiedBy { get; set; }
    }
}
