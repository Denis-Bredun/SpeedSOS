using FluentValidation;
using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.DTOs.Validation;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedToastService(
        IToastService innerToastService,
        ILogger<LoggedToastService> logger) : IToastService
    {
        public async Task ShowToastAsync(ToastRequest request)
        {
            try
            {
                await innerToastService.ShowToastAsync(request);
            }
            catch (ValidationException ex)
            {
                logger.LogError(ex, LogMessages.FormatToastValidationErrorMessage(ex));
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.ToastUnexpected, request.Message);
                throw;
            }
        }
    }
}
