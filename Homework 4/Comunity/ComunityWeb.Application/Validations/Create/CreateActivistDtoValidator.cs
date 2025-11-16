using FluentValidation;
using Community.Application.Validators;
using System.Text.RegularExpressions;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class CreateActivistDtoValidator : AbstractValidator<ActivistDTO>
{
    public CreateActivistDtoValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("Nombre completo es requerido")
            .MinimumLength(5);

        RuleFor(x => x.Cedula)
            .NotEmpty()
            .Matches(new Regex(@"^\d{3}-\d{7}-\d{1}$"))
            .WithMessage("Cédula inválida. Formato requerido: 000-0000000-0");

        RuleFor(x => x.Phone)
            .NotEmpty()
            .Matches(@"^\d{10}$").WithMessage("Teléfono debe tener 10 dígitos");

        RuleFor(x => x.Zone).NotEmpty();
        RuleFor(x => x.Level).NotEmpty();
    }
}
