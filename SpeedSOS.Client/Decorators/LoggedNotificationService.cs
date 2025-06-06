using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedNotificationService(
    INotificationService innerNotificationService,
    ILogger<LoggedNotificationService> logger) : INotificationService
    {
        public async Task ShowToastAsync(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            await innerNotificationService.ShowToastAsync(message, textSize, duration);
        }

        public async Task<bool> ShowYesNoDialogAsync(
            string message,
            string title = DefaultArguments.ConfirmDialogTitle,
            string yesText = DefaultArguments.ConfirmYes,
            string noText = DefaultArguments.ConfirmNo)
        {
            try
            {
                return await innerNotificationService.ShowYesNoDialogAsync(message, title, yesText, noText);
            }
            catch (ArgumentException ex)
            {
                logger.LogError(ex, LogMessages.NotificationDialogInvalidArgument, message);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.NotificationDialogUnexpected, message);
                throw;
            }
        }

        public async Task<string> ShowActionSheetAsync(
            string title = DefaultArguments.ActionSheetDefaultMessage,
            string cancel = DefaultArguments.ActionSheetCancel,
            string destruction = DefaultArguments.ActionSheetDestruction,
            params string[] options)
        {
            try
            {
                return await innerNotificationService.ShowActionSheetAsync(title, cancel, destruction, options);
            }
            catch (ArgumentException ex)
            {
                logger.LogError(ex, LogMessages.NotificationActionSheetInvalidArgument, title, options?.Length ?? 0);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.NotificationActionSheetUnexpected, title);
                throw;
            }
        }
    }

}
