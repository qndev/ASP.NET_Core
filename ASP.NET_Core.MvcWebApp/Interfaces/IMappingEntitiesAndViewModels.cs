namespace ASP.NET_Core.MvcWebApp.Interfaces
{
    public interface IMappingEntitiesAndViewModels
    {
        TDestination CreateMapping<TDestination>(object source);
    }
}
