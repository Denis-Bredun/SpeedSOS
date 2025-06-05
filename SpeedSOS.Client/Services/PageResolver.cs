using SpeedSOS.Client.Interfaces;

namespace SpeedSOS.Client.Services
{
    public class PageResolver : IPageResolver
    {
        public Page GetCurrentPage()
        {
            if (Application.Current is null)
                throw new InvalidOperationException("Application.Current is null. Ensure the application is initialized.");

            if (Application.Current.MainPage is null)
                throw new InvalidOperationException("Application.Current.MainPage is null. Ensure the main page is set.");

            return Application.Current.MainPage;
        }
    }
}
