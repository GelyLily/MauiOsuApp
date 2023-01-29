using CommunityToolkit.Mvvm.Messaging;
using MauiOsuApp.Services.Navigation;
using MauiOsuApp.ViewModels;
using MauiOsuApp.Views;

namespace MauiOsuApp.Views;

public partial class MainPage : ContentPageBase
{
	public MainPage(MainViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
    }

}

