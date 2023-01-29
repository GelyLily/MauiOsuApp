using MauiOsuApp.Services.Navigation;

namespace MauiOsuApp;

public partial class App : Application
{
    private readonly INavigationService _navigationService;

    public App(INavigationService navigationService)
	{
		InitializeComponent();

        _navigationService = navigationService;

        MainPage = new AppShell(navigationService);
	}
}
