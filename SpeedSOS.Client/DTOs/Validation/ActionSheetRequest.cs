using SpeedSOS.Client.Constants;

namespace SpeedSOS.Client.DTOs.Validation
{
    public class ActionSheetRequest
    {
        public string Title { get; set; } = DefaultArguments.ActionSheetDefaultMessage;
        public string Cancel { get; set; } = DefaultArguments.ActionSheetCancel;
        public string Destruction { get; set; } = DefaultArguments.ActionSheetDestruction;
        public string[] Options { get; set; } = Array.Empty<string>();
    }
}
