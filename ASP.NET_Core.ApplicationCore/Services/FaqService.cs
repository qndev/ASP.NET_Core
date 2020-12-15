using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class FaqService : AsyncCrudService<Faq, int>, IFaqService
    {
        public FaqService(IRepository<Faq, int> repository)
            : base(repository)
        {
        }
    }
}
