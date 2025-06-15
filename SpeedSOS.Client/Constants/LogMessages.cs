using FluentValidation;
using FluentValidation.Results;

namespace SpeedSOS.Client.Constants
{
    public static class LogMessages
    {
        public const string ToastValidationFailed = "Validation failed for ShowToastAsync request";
        public const string ToastUnexpected = "An unexpected error occurred while showing toast: {Message}";
        public static string FormatToastValidationErrorMessage(ValidationException ex) =>
        $"{ToastValidationFailed}. Details: {FormatValidationErrors(ex.Errors)}";

        public const string PageResolverFailed = "Failed to get current page from inner resolver.";
        public const string PageResolverUnexpected = "An unexpected error occurred while getting the current page.";
        public static string FormatPageResolverValidationErrorMessage(ValidationException ex) =>
        $"{PageResolverFailed}. Details: {FormatValidationErrors(ex.Errors)}";

        public const string NotificationDialogUnexpected =
            "An unexpected error occurred while showing Yes/No dialog: message='{Message}', title='{Title}', yes='{Yes}', no='{No}'";

        public const string NotificationActionSheetUnexpected =
            "An unexpected error occurred while showing ActionSheet: title='{Title}', cancel='{Cancel}', destruction='{Destruction}', optionsCount={OptionsCount}, options=[{Options}]";

        public static string FormatYesNoDialogValidationErrorMessage(
        ValidationException ex,
        string message,
        string title,
        string yes,
        string no) =>
        $"Validation failed for Yes/No dialog: message='{message}', title='{title}', yes='{yes}', no='{no}'. " +
        $"Details: {FormatValidationErrors(ex.Errors)}";

        public static string FormatActionSheetValidationErrorMessage(
        ValidationException ex,
        string title,
        string cancel,
        string destruction,
        string[]? options) =>
        $"Validation failed for ActionSheet: title='{title}', cancel='{cancel}', destruction='{destruction}', " +
        $"optionsCount={options?.Length ?? 0}, options=[{string.Join(", ", options ?? Array.Empty<string>())}]. " +
        $"Details: {FormatValidationErrors(ex.Errors)}";

        public static string FormatValidationErrors(IEnumerable<ValidationFailure> errors) =>
        string.Join(" | ", errors.Select(e => $"{e.PropertyName}: {e.ErrorMessage}"));
    }
}
