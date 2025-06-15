using CommunityToolkit.Maui.Core;
using FluentValidation;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.DTOs.Validation;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class NotificationService(
        IPageResolver pageResolver,
        IToastService toastService,
        IValidator<YesNoDialogRequest> yesNoValidator,
        IValidator<ActionSheetRequest> actionSheetValidator) : INotificationService
    {
        public async Task ShowToastAsync(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            var request = new ToastRequest
            {
                Message = message,
                TextSize = textSize,
                Duration = duration
            };

            await toastService.ShowToastAsync(request);
        }

        public async Task<bool> ShowYesNoDialogAsync(
        string message,
        string title = DefaultArguments.ConfirmDialogTitle,
        string yesText = DefaultArguments.ConfirmYes,
        string noText = DefaultArguments.ConfirmNo)
        {
            var request = new YesNoDialogRequest
            {
                Message = message,
                Title = title,
                YesText = yesText,
                NoText = noText
            };

            await yesNoValidator.ValidateAndThrowAsync(request);

            var currentPage = pageResolver.GetCurrentPage();
            return await currentPage.DisplayAlert(title, message, yesText, noText);
        }

        public async Task<string> ShowActionSheetAsync(
        string title = DefaultArguments.ActionSheetDefaultMessage,
        string cancel = DefaultArguments.ActionSheetCancel,
        string destruction = DefaultArguments.ActionSheetDestruction,
        params string[] options)
        {
            var request = new ActionSheetRequest
            {
                Title = title,
                Cancel = cancel,
                Destruction = destruction,
                Options = options
            };

            await actionSheetValidator.ValidateAndThrowAsync(request);

            var currentPage = pageResolver.GetCurrentPage();
            return await currentPage.DisplayActionSheet(title, cancel, destruction, options);
        }
    }
}
