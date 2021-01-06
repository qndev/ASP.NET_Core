using AutoMapper;

namespace ASP.NET_Core.ApplicationCore.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDtoProfile());
            });
 
            return mapperConfiguration.CreateMapper();
        }
    }
}
