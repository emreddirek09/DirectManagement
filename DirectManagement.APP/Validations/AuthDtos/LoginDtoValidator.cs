using DirectManagement.APP.Constants;
using DirectManagement.DOMAIN.DTOS.AuthDtos;
using FluentValidation; 

namespace DirectManagement.APP.Validations.AuthDtos;

public class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(string.Format(ValidationMessages.NotEmpty, "E-mail"))
            .EmailAddress().WithMessage(ValidationMessages.InvalidEmail);

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage(string.Format(ValidationMessages.NotEmpty, "Şifre"))
            .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.")
            .MaximumLength(12).WithMessage("Şifre en fazla 12 karakter olmalıdır.");
    }
}
