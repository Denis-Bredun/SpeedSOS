namespace SpeedSOS.Client.Constants
{
    public static class LogMessages
    {
        public const string ToastInvalidArgument = "Invalid argument provided for ShowToast: message: {Message}";
        public const string ToastOutOfRange = "Argument out of range for ShowToast: textSize: {TextSize}";
        public const string ToastUnexpected = "An unexpected error occurred while showing toast: {Message}";

        public const string PageResolverFailed = "Failed to get current page from inner resolver.";
        public const string PageResolverUnexpected = "An unexpected error occurred while getting the current page.";
    }
}
