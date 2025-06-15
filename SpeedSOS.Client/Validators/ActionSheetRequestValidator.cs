using FluentValidation;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.DTOs.Validation;

namespace SpeedSOS.Client.Validators
{
    public class ActionSheetRequestValidator : AbstractValidator<ActionSheetRequest>
    {
        public ActionSheetRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(ExceptionMessages.ActionSheetTitleNullOrEmpty);

            RuleFor(x => x.Cancel)
                .NotEmpty()
                .WithMessage(ExceptionMessages.ActionSheetCancelNullOrEmpty);

            RuleFor(x => x.Destruction)
                .NotEmpty()
                .WithMessage(ExceptionMessages.ActionSheetDestructionNullOrEmpty);

            RuleFor(x => x.Options)
                .NotEmpty()
                .WithMessage(ExceptionMessages.ActionSheetOptionsNullOrEmpty);
        }
    }
}
