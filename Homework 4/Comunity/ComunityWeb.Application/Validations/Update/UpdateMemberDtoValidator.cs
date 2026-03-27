using FluentValidation;
using Community.Application.Validators;
using ComunityWeb.Application.DTOs.Enums;

namespace Community.Application.Validators;

public class UpdateMemberDtoValidator : AbstractValidator<MemberDTO>
{
    public UpdateMemberDtoValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id inválido");
        Include(new CreateMemberDtoValidator());
    }
}
