using Microsoft.Extensions.Logging;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Decorators
{
    public class LoggedPageResolver : IPageResolver
    {
        private readonly IPageResolver _innerPageResolver;
        private readonly ILogger<LoggedPageResolver> _logger;

        public LoggedPageResolver(
            IPageResolver innerPageResolver,
            ILogger<LoggedPageResolver> logger)
        {
            _innerPageResolver = innerPageResolver;
            _logger = logger;
        }

        public Page GetCurrentPage()
        {
            Page page;

            try
            {
                page = _innerPageResolver.GetCurrentPage();
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "Failed to get current page from inner resolver.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while getting the current page.");
                throw;
            }

            return page;
        }
    }
}
