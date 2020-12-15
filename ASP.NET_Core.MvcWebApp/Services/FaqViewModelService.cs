using ASP.NET_Core.MvcWebApp.Models.FaqViewModels;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.MvcWebApp.Interfaces;

namespace ASP.NET_Core.MvcWebApp.Services
{
    public class FaqViewModelService : IMappingEntitiesAndViewModels
    {
        public TDestination CreateMapping<TDestination>(object source)
        {
             return CreateMapping<TDestination>(source);
        }
    }
}
