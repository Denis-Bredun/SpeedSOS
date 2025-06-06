namespace SpeedSOS.Client.Constants
{
    public static class ExceptionMessages
    {
        public const string ToastMessageNullOrEmpty = "Message cannot be null or empty.";
        public const string ToastTextSizeInvalid = "Text size must be greater than zero.";

        public const string AppNull = "Application.Current is null. Ensure the application is initialized.";
        public const string MainPageNull = "Application.Current.MainPage is null. Ensure the main page is set.";

        public const string DialogMessageNullOrEmpty = "Dialog message cannot be null or empty.";
        public const string DialogTitleNullOrEmpty = "Dialog title cannot be null or empty.";
        public const string DialogYesTextNullOrEmpty = "Dialog 'Yes' button text cannot be null or empty.";
        public const string DialogNoTextNullOrEmpty = "Dialog 'No' button text cannot be null or empty.";

        public const string ActionSheetTitleNullOrEmpty = "Action sheet title cannot be null or empty.";
        public const string ActionSheetCancelNullOrEmpty = "Action sheet cancel text cannot be null or empty.";
        public const string ActionSheetOptionsNullOrEmpty = "At least one option must be provided for the action sheet.";
    }
}
