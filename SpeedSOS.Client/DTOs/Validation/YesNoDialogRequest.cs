using SpeedSOS.Client.Constants;

namespace SpeedSOS.Client.DTOs.Validation
{
    public class YesNoDialogRequest
    {
        public string Message { get; set; } = null!;
        public string Title { get; set; } = DefaultArguments.ConfirmDialogTitle;
        public string YesText { get; set; } = DefaultArguments.ConfirmYes;
        public string NoText { get; set; } = DefaultArguments.ConfirmNo;
    }
}
