using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Dtos.Faq;
using ASP.NET_Core.ApplicationCore.Dtos;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IFaqService : IAsyncCrudService<Faq, int>
    {
    }
}
