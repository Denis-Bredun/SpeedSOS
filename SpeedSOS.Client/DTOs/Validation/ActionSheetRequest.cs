namespace SpeedSOS.Client.DTOs.Validation
{
    public class ActionSheetRequest
    {
        public string Title { get; set; } = null!;
        public string Cancel { get; set; } = null!;
        public string Destruction { get; set; } = null!;
        public string[] Options { get; set; } = Array.Empty<string>();
    }
}
