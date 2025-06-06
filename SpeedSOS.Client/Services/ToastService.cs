using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class ToastService : IToastService
    {
        public async Task ShowToast(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(ExceptionMessages.ToastMessageNullOrEmpty, nameof(message));

            if (textSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(textSize), ExceptionMessages.ToastTextSizeInvalid);

            await Toast.Make(message, duration, textSize).Show();
        }
    }
}
