namespace SpeedSOS.Client.Constants
{
    public static class LogMessages
    {
        public const string ToastInvalidArgument = "Invalid argument provided for ShowToast: message: {Message}";
        public const string ToastOutOfRange = "Argument out of range for ShowToast: textSize: {TextSize}";
        public const string ToastUnexpected = "An unexpected error occurred while showing toast: {Message}";

        public const string PageResolverFailed = "Failed to get current page from inner resolver.";
        public const string PageResolverUnexpected = "An unexpected error occurred while getting the current page.";

        public const string NotificationDialogInvalidArgument =
        "Invalid argument provided for Yes/No dialog: message='{Message}', title='{Title}', yes='{Yes}', no='{No}'";

        public const string NotificationDialogUnexpected =
            "An unexpected error occurred while showing Yes/No dialog: message='{Message}', title='{Title}', yes='{Yes}', no='{No}'";

        public const string NotificationActionSheetInvalidArgument =
            "Invalid argument provided for ActionSheet: title='{Title}', cancel='{Cancel}', destruction='{Destruction}', optionsCount={OptionsCount}, options=[{Options}]";

        public const string NotificationActionSheetUnexpected =
            "An unexpected error occurred while showing ActionSheet: title='{Title}', cancel='{Cancel}', destruction='{Destruction}', optionsCount={OptionsCount}, options=[{Options}]";
    }
}
