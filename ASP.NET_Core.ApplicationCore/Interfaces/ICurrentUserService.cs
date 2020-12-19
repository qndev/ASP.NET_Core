namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        string UserEmail { get; }
        bool UserLoggedIn { get; }
    }
}
