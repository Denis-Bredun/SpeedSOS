using CommunityToolkit.Maui.Core;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class NotificationService(
        IPageResolver pageResolver,
        IToastService toastService) : INotificationService
    {
        public async Task ShowToastAsync(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            await toastService.ShowToast(message, textSize, duration);
        }

        public async Task<bool> ShowYesNoDialogAsync(
        string message,
        string title = DefaultArguments.ConfirmDialogTitle,
        string yesText = DefaultArguments.ConfirmYes,
        string noText = DefaultArguments.ConfirmNo)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(ExceptionMessages.DialogMessageNullOrEmpty, nameof(message));

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException(ExceptionMessages.DialogTitleNullOrEmpty, nameof(title));

            if (string.IsNullOrWhiteSpace(yesText))
                throw new ArgumentException(ExceptionMessages.DialogYesTextNullOrEmpty, nameof(yesText));

            if (string.IsNullOrWhiteSpace(noText))
                throw new ArgumentException(ExceptionMessages.DialogNoTextNullOrEmpty, nameof(noText));

            var currentPage = pageResolver.GetCurrentPage();
            return await currentPage.DisplayAlert(title, message, yesText, noText);
        }

        public async Task<string> ShowActionSheetAsync(
            string title = DefaultArguments.ActionSheetDefaultMessage,
            string cancel = DefaultArguments.ActionSheetCancel,
            string destruction = DefaultArguments.ActionSheetDestruction,
            params string[] options)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException(ExceptionMessages.ActionSheetTitleNullOrEmpty, nameof(title));

            if (string.IsNullOrWhiteSpace(cancel))
                throw new ArgumentException(ExceptionMessages.ActionSheetCancelNullOrEmpty, nameof(cancel));

            if (options == null || options.Length == 0)
                throw new ArgumentException(ExceptionMessages.ActionSheetOptionsNullOrEmpty, nameof(options));

            var currentPage = pageResolver.GetCurrentPage();
            return await currentPage.DisplayActionSheet(title, cancel, destruction, options);
        }
    }
}
