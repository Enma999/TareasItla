using FluentValidation;
using Community.Application.Validators;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class CreateCoordinatorDtoValidator : AbstractValidator<CoordinatorDTO>
{
    public CreateCoordinatorDtoValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().MinimumLength(5);
        RuleFor(x => x.Phone).NotEmpty().Matches(@"^\d{10}$");
        RuleFor(x => x.Sector).NotEmpty();
        RuleFor(x => x.CommitteeName).NotEmpty();
    }
}
