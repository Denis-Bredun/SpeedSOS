using CommunityToolkit.Maui.Core;
using SpeedSOS.Client.Constants;

namespace SpeedSOS.Client.Interfaces
{
    public interface INotificationService
    {
        Task ShowToastAsync(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration);

        Task<bool> ShowYesNoDialogAsync(string message,
            string title = DefaultArguments.ConfirmDialogTitle,
            string yesText = DefaultArguments.ConfirmYes,
            string noText = DefaultArguments.ConfirmNo);

        Task<string> ShowActionSheetAsync(
            string title = DefaultArguments.ActionSheetDefaultMessage,
            string cancel = DefaultArguments.ActionSheetCancel,
            string destruction = DefaultArguments.ActionSheetDestruction,
            params string[] options);
    }
}
