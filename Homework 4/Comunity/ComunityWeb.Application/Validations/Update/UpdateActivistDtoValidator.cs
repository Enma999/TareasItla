using FluentValidation;
using Community.Application.Validators;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class UpdateActivistDtoValidator : AbstractValidator<ActivistDTO>
{
    public UpdateActivistDtoValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        Include(new CreateActivistDtoValidator());
    }
}
