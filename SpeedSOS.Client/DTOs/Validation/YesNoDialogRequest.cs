namespace SpeedSOS.Client.DTOs.Validation
{
    public class YesNoDialogRequest
    {
        public string Message { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string YesText { get; set; } = null!;
        public string NoText { get; set; } = null!;
    }
}
