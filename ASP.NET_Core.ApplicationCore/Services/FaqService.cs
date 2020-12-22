using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class FaqService : AsyncCrudService<Faq, string>, IFaqService
    {
        public FaqService(IRepository<Faq, string> repository)
            : base(repository)
        {
        }
    }
}
