namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface ICurrentUserService
    {
        int UserId { get; }
        string UserEmail { get; }
        bool UserLoggedIn { get; }
    }
}
