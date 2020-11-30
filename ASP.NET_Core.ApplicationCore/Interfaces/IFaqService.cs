using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Dtos.Faq;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IFaqService : IAsyncCrudService<Faq, FaqDto, int, CreateUpdateFaqDto>
    {
    }
}
