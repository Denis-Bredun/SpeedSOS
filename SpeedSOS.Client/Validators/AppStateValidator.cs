using FluentValidation;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.ValueObject;

namespace SpeedSOS.Client.Validators
{
    public class AppStateValidator : AbstractValidator<AppState>
    {
        public AppStateValidator()
        {
            RuleFor(x => x.Current)
                .NotNull().WithMessage(ExceptionMessages.AppNull);

            RuleFor(x => x.MainPage)
                .NotNull().WithMessage(ExceptionMessages.MainPageNull);
        }
    }
}
