using ASP.NET_Core.MvcWebApp.Models.FaqViewModels;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.MvcWebApp.Interfaces;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.MvcWebApp.Services
{
    public class FaqViewModelService : IMappingEntitiesAndViewModels<FaqViewModel, Faq>, IMappingEntitiesAndViewModels<Faq, FaqViewModel>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public FaqViewModelService(
            ICurrentUserService currentUserService,
            IDateTime dateTime
        )
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public FaqViewModel CreateMapping(Faq faq)
        {
            return new FaqViewModel
            {
                Answer = faq.Answer,
                Question = faq.Question
            };
        }

        public Faq CreateMapping(FaqViewModel faqViewModel)
        {
            Faq faq = new Faq
            {
                Question = faqViewModel.Question,
                Answer = faqViewModel.Answer,
                CreatedBy = _currentUserService.UserId,
                ModifiedBy = _currentUserService.UserId,
                CreationTime = _dateTime.Now
            };
            return faq;
        }
    }
}
