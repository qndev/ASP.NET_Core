using FluentValidation;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.ApplicationCore.Validators
{
    public class FaqValidator : AbstractValidator<Faq>
    {
        public FaqValidator()
        {
            RuleFor(faq => faq.Answer).NotEmpty().WithMessage("The answer field is required");
            RuleFor(faq => faq.Question).NotEmpty().WithMessage("The question field is required");
            RuleFor(faq => faq.UserId).NotEmpty();
            RuleFor(faq => faq.ModifiedBy).NotEmpty();
            RuleFor(faq => faq.CreationTime).NotEmpty();
        }
    }
}
