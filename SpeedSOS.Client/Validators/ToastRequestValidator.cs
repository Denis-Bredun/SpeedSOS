using FluentValidation;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.DTOs.Validation;

namespace SpeedSOS.Client.Validators
{
    public class ToastRequestValidator : AbstractValidator<ToastRequest>
    {
        public ToastRequestValidator()
        {
            RuleFor(x => x.Message)
                .NotEmpty()
                .WithMessage(ExceptionMessages.ToastMessageNullOrEmpty);

            RuleFor(x => x.TextSize)
                .GreaterThan(0)
                .WithMessage(ExceptionMessages.ToastTextSizeInvalid);
        }
    }
}
