using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation;

public class PortfolioValidator : AbstractValidator<Portfolio>
{
    public PortfolioValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image Url cannot be empty");
        RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Project Url cannot be empty");
        RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform cannot be empty");
        RuleFor(x => x.Price).NotEmpty().WithMessage("Price cannot be empty");
        RuleFor(x => x.Name).MinimumLength(5).WithMessage("Name cannot be less than 5 characters");
        RuleFor(x => x.Name).MaximumLength(100).WithMessage("Name cannot be more than 100 characters");
    }
}