using Avalonia;
using FirLib.Core.Infrastructure;

namespace FirLib.Core;

public static class AppBuilderExtensions
{
    public static AppBuilder UseFirLibEnvironment(this AppBuilder appBuilder)
    {
        // Initialize base application logic
        appBuilder.AfterSetup(_ =>
        {
            FirLibApplication.GetLoader()
                .AttachToAvaloniaEnvironment()
                .Load();
        });

        return appBuilder;
    }
}