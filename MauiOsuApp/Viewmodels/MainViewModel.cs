using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiOsuApp.Services.Navigation;
using MauiOsuApp.Services.Settings;
using MauiOsuApp.ViewModels.Base;

namespace MauiOsuApp.ViewModels
{

    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string message = "Click me";

        public ICommand NavigateProfileCommand { get; }


        public MainViewModel(INavigationService navigationService, ISettingsService settingsService)
            : base(navigationService, settingsService)
        {
            NavigateProfileCommand = new AsyncRelayCommand(NavigateProfile);
        }
        
        private async Task NavigateProfile()
        {
            await NavigationService.NavigateToAsync("Profile");
            
        }
    }
}
