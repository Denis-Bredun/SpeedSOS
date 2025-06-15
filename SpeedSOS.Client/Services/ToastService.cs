using CommunityToolkit.Maui.Alerts;
using FluentValidation;
using SpeedSOS.Client.DTOs.Validation;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class ToastService : IToastService
    {
        private readonly IValidator<ToastRequest> _validator;

        public ToastService(IValidator<ToastRequest> validator)
        {
            _validator = validator;
        }

        public async Task ShowToastAsync(ToastRequest request)
        {
            await _validator.ValidateAndThrowAsync(request);
            await Toast.Make(request.Message, request.Duration, request.TextSize).Show();
        }
    }
}
