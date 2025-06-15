using FluentValidation;
using SpeedSOS.Client.Interfaces;
using SpeedSOS.Client.ValueObject;

namespace SpeedSOS.Client.Services
{
    public class PageResolver : IPageResolver
    {
        private readonly IValidator<AppState> _validator;

        public PageResolver(IValidator<AppState> validator)
        {
            _validator = validator;
        }

        public Page GetCurrentPage()
        {
            var appState = new AppState
            {
                Current = Application.Current,
                MainPage = Application.Current?.MainPage
            };

            _validator.ValidateAndThrow(appState);

            return appState.MainPage!;
        }
    }
}
