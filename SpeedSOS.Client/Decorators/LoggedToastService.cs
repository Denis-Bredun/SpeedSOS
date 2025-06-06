using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedToastService(
        IToastService innerToastService,
        ILogger<LoggedToastService> logger) : IToastService
    {
        public async Task ShowToast(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            try
            {
                await innerToastService.ShowToast(message, textSize, duration);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                logger.LogError(ex, LogMessages.ToastOutOfRange, textSize);
                throw;
            }
            catch (ArgumentException ex)
            {
                logger.LogError(ex, LogMessages.ToastInvalidArgument, message);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.ToastUnexpected, message);
                throw;
            }
        }
    }
}
