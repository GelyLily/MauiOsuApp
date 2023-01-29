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
using MauiOsuApp.Views;

namespace MauiOsuApp.ViewModels
{

    public partial class MainViewModel : BaseViewModel
    {

        public MainViewModel(INavigationService navigationService, ISettingsService settingsService)
            : base(navigationService, settingsService)
        {
        }

        [RelayCommand]
        Task NavigateProfile() => NavigationService.NavigateToAsync(nameof(ProfilePage));

    }
}
