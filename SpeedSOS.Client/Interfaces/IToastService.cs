using SpeedSOS.Client.DTOs.Validation;

namespace SpeedSOS.Client.Interfaces
{
    public interface IToastService
    {
        Task ShowToastAsync(ToastRequest request);
    }
}
