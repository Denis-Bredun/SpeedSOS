namespace SpeedSOS.Client.Constants
{
    public static class ExceptionMessages
    {
        public const string ToastMessageNullOrEmpty = "Message cannot be null or empty.";
        public const string ToastTextSizeInvalid = "Text size must be greater than zero.";

        public const string AppNull = "Application.Current is null. Ensure the application is initialized.";
        public const string MainPageNull = "Application.Current.MainPage is null. Ensure the main page is set.";
    }
}
