using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Serilog;

namespace SpeedSOS.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            ConfigureLogging();

            var builder = MauiApp.CreateBuilder();
            ConfigureMaui(builder);

            return builder.Build();
        }

        private static void ConfigureLogging()
        {
            var logFilePath = Path.Combine(FileSystem.AppDataDirectory, "logs", "app.log");
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath)!);

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        private static void ConfigureMaui(MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(dispose: true);
        }
    }
}
