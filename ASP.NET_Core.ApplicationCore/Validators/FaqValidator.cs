using FluentValidation;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.ApplicationCore.Validators
{
    public class FaqValidator : AbstractValidator<Faq>
	{
    	public FaqValidator() {
        	RuleFor(faq => faq.Answer).NotNull().WithMessage("Required");
        	RuleFor(faq => faq.Question).NotNull().WithMessage("Required");
  		}
	}
}
