using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class NotificationService : INotificationService
    {
        public async Task ShowToastAsync(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            var notification = Toast.Make(message, duration, textSize);
            await notification.Show();
        }

        public async Task<bool> ShowYesNoDialogAsync(
            string message,
            string title = DefaultArguments.ConfirmDialogTitle,
            string yesText = DefaultArguments.ConfirmYes,
            string noText = DefaultArguments.ConfirmNo)
        {
            return await GetCurrentPage().DisplayAlert(title, message, yesText, noText);
        }

        public async Task<string> ShowActionSheetAsync(
            string title = DefaultArguments.ActionSheetDefaultMessage,
            string cancel = DefaultArguments.ActionSheetCancel,
            string destruction = DefaultArguments.ActionSheetDestruction,
            params string[] options)
        {
            return await GetCurrentPage().DisplayActionSheet(title, cancel, destruction, options);
        }

        private Page GetCurrentPage()
        {
            if (Application.Current is null)
                throw new InvalidOperationException("Application.Current is null. Ensure the application is initialized.");

            if (Application.Current.MainPage is null)
                throw new InvalidOperationException("Application.Current.MainPage is null. Ensure the main page is set.");

            return Application.Current.MainPage;
        }
    }
}
