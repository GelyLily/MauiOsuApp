using MauiOsuApp.ViewModels.Base;

namespace MauiOsuApp.Views;

public abstract class ContentPageBase : ContentPage
{
    public ContentPageBase()
    {
        NavigationPage.SetBackButtonTitle(this, string.Empty);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is IBaseViewModel ivmb && !ivmb.IsInitialized)
        {
            ivmb.IsInitialized = true;
            await ivmb.InitializeAsync();
        }
    }
}