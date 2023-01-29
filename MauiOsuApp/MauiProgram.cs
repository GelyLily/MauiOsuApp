using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MauiOsuApp.ViewModels;
using Microsoft.Maui.Hosting;
using MauiOsuApp.Services.Navigation;

namespace MauiOsuApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit()
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>(); ;

        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainViewModel>(); //Singletons last the entire lifetime of the application

        mauiAppBuilder.Services.AddTransient<ProfileViewModel>(); //Transients will follow the lifetime of their host

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<MainPage>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterModels(this MauiAppBuilder mauiAppBuilder)
    {
        // mauiAppBuilder.Services.AddTransient<Item>();

        return mauiAppBuilder;
    }

}