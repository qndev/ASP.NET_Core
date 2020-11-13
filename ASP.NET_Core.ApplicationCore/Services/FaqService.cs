using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Dtos.Faq;
using ASP.NET_Core.ApplicationCore.Dtos;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class FaqService : AsyncCrudService<Faq, FaqDto, int, CreateUpdateFaqDto>, IFaqService
    {
        public FaqService(IRepository<Faq, int> repository)
            : base(repository)
        {
        }
    }
}
