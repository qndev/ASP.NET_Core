using AutoMapper;
using ASP.NET_Core.ApplicationCore.Dtos.Faq;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Dtos;

namespace ASP.NET_Core.ApplicationCore.AutoMapper
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<CreateUpdateFaqDto, Faq>();
            CreateMap<Faq, EntityDto<int>>();
            CreateMap<Faq, FaqDto>();
        }
    }
}
