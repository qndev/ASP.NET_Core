using ASP.NET_Core.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IFaqService : IAsyncCrudService<Faq, string>
    {
    }
}
