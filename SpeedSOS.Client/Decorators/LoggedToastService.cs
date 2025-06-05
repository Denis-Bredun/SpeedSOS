using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedToastService : IToastService
    {
        private readonly IToastService _innerToastService;
        private readonly ILogger<LoggedToastService> _logger;

        public LoggedToastService(
            IToastService innerToastService,
            ILogger<LoggedToastService> logger)
        {
            _innerToastService = innerToastService;
            _logger = logger;
        }

        public async Task ShowToast(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            try
            {
                await _innerToastService.ShowToast(message, textSize, duration);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _logger.LogError(ex, "Argument out of range for ShowToast: duration: {Duration}", duration);
                throw;
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "Invalid argument provided for ShowToast: message: {Message}", message);
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while showing toast: {Message}", message);
                throw;
            }
        }
    }
}
