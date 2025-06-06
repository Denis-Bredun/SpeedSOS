using SpeedSOS.Client.Constants;
using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class PageResolver : IPageResolver
    {
        public Page GetCurrentPage()
        {
            if (Application.Current is null)
                throw new InvalidOperationException(ExceptionMessages.AppNull);

            if (Application.Current.MainPage is null)
                throw new InvalidOperationException(ExceptionMessages.MainPageNull);

            return Application.Current.MainPage;
        }
    }
}
