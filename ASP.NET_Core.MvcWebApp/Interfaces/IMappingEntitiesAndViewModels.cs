namespace ASP.NET_Core.MvcWebApp.Interfaces
{
    public interface IMappingEntitiesAndViewModels<TSource, TDestination>
        where TSource : class
        where TDestination : class
    {
        TDestination CreateMapping(TSource source);
    }
}
