using MauiOsuApp.Services.Navigation;
using MauiOsuApp.ViewModels;
using MauiOsuApp.Views;

namespace MauiOsuApp.Views;

public partial class ProfilePage : ContentPageBase
{
	public ProfilePage(ProfileViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}