using FluentValidation;
using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedPageResolver(
    IPageResolver innerPageResolver,
    ILogger<LoggedPageResolver> logger) : IPageResolver
    {
        public Page GetCurrentPage()
        {
            try
            {
                return innerPageResolver.GetCurrentPage();
            }
            catch (ValidationException ex)
            {
                logger.LogError(ex, LogMessages.FormatPageResolverValidationErrorMessage(ex));
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.PageResolverUnexpected);
                throw;
            }
        }
    }
}
