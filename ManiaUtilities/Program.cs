using Avalonia;
using System;

namespace ManiaUtilities;

static class Program
{
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    private static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect()
            
    #if DEBUG
        .WithDeveloperTools()
    #endif
        .WithInterFont()
        .LogToTrace();
}