using FluentValidation;
using Community.Application.Validators;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class UpdateChairmanDtoValidator : AbstractValidator<ChairmanDTO>
{
    public UpdateChairmanDtoValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        Include(new CreateChairmanDtoValidator());
    }
}
