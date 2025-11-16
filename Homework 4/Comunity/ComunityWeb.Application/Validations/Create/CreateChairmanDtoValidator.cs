using FluentValidation;
using Community.Application.Validators;
using System;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class CreateChairmanDtoValidator : AbstractValidator<ChairmanDTO>
{
    public CreateChairmanDtoValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty().MinimumLength(5);

        RuleFor(x => x.Phone)
            .NotEmpty().Matches(@"^\d{10}$").WithMessage("Teléfono debe tener 10 dígitos");

        RuleFor(x => x.CommunityName).NotEmpty();
    }
}
