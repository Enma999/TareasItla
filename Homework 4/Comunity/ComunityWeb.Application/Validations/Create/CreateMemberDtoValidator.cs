using FluentValidation;
using Community.Application.Validators;
using System.Text.RegularExpressions;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class CreateMemberDtoValidator : AbstractValidator<MemberDTO>
{
    public CreateMemberDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Nombre es requerido")
            .MinimumLength(3).WithMessage("Nombre debe tener al menos 3 caracteres");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Apellido es requerido")
            .MinimumLength(3).WithMessage("Apellido debe tener al menos 3 caracteres");

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Teléfono es requerido")
            .Matches(new Regex(@"^\d{10}$")).WithMessage("Teléfono debe tener 10 dígitos numéricos");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Dirección es requerida")
            .MinimumLength(5);
    }
}
