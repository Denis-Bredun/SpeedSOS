using CommunityToolkit.Maui.Core;
using SpeedSOS.Client.Constants;

namespace SpeedSOS.Client.Interfaces
{
    public interface IToastService
    {
        Task ShowToast(
            string message,
            double textSize = DefaultArguments.ToastTextSize,
            ToastDuration duration = DefaultArguments.DefaultToastDuration);
    }
}
