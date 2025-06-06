namespace SpeedSOS.Client.Constants
{
    public static class LogMessages
    {
        public const string ToastInvalidArgument = "Invalid argument provided for ShowToast: message: {Message}";
        public const string ToastOutOfRange = "Argument out of range for ShowToast: textSize: {TextSize}";
        public const string ToastUnexpected = "An unexpected error occurred while showing toast: {Message}";

        public const string PageResolverFailed = "Failed to get current page from inner resolver.";
        public const string PageResolverUnexpected = "An unexpected error occurred while getting the current page.";

        public const string NotificationDialogInvalidArgument = "Invalid argument for ShowYesNoDialogAsync: {Message}";
        public const string NotificationDialogUnexpected = "Unexpected error in ShowYesNoDialogAsync with message: {Message}";

        public const string NotificationActionSheetInvalidArgument = "Invalid argument for ShowActionSheetAsync: title: {Title}, options count: {OptionsCount}";
        public const string NotificationActionSheetUnexpected = "Unexpected error in ShowActionSheetAsync with title: {Title}";
    }
}
