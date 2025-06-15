using CommunityToolkit.Maui.Core;

namespace SpeedSOS.Client.DTOs.Validation
{
    public class ToastRequest
    {
        public string Message { get; set; } = null!;
        public double TextSize { get; set; }
        public ToastDuration Duration { get; set; }
    }
}
