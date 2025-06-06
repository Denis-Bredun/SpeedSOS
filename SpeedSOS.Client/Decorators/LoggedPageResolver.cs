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
            Page page;

            try
            {
                page = innerPageResolver.GetCurrentPage();
            }
            catch (InvalidOperationException ex)
            {
                logger.LogError(ex, LogMessages.PageResolverFailed);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.PageResolverUnexpected);
                throw;
            }

            return page;
        }
    }
}
