using FluentValidation;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.DTOs.Validation;

namespace SpeedSOS.Client.Validators
{
    public class YesNoDialogRequestValidator : AbstractValidator<YesNoDialogRequest>
    {
        public YesNoDialogRequestValidator()
        {
            RuleFor(x => x.Message)
                .NotEmpty()
                .WithMessage(ExceptionMessages.DialogMessageNullOrEmpty);

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(ExceptionMessages.DialogTitleNullOrEmpty);

            RuleFor(x => x.YesText)
                .NotEmpty()
                .WithMessage(ExceptionMessages.DialogYesTextNullOrEmpty);

            RuleFor(x => x.NoText)
                .NotEmpty()
                .WithMessage(ExceptionMessages.DialogNoTextNullOrEmpty);
        }
    }
}
