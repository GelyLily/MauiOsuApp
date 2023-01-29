using CommunityToolkit.Mvvm.ComponentModel;
using MauiOsuApp.Services.Navigation;
using MauiOsuApp.Services.Settings;
using System.ComponentModel;

namespace MauiOsuApp.ViewModels.Base
{
    public abstract class BaseViewModel : ObservableObject, IBaseViewModel
    {
        private bool _isInitialized;
        private bool _isBusy;

        public INavigationService NavigationService { get; private set; }

        public ISettingsService SettingsService { get; private set; }

        public bool IsBusy
        {
            get => _isBusy;
            private set => SetProperty(ref _isBusy, value);
        }

        public bool IsInitialized
        {
            get => _isInitialized;
            set => SetProperty(ref _isInitialized, value);
        }

        public BaseViewModel(INavigationService navigationService, ISettingsService settingsService)
        {
            NavigationService = navigationService;
            SettingsService = settingsService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
        }

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
