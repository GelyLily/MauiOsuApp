using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiOsuApp.ViewModels.Base;
using MauiOsuApp.Services.Navigation;
using MauiOsuApp.Services.Settings;

namespace MauiOsuApp.ViewModels
{
    public partial class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel(INavigationService navigationService, ISettingsService settingsService)
            : base(navigationService, settingsService)
        {

        }

        [RelayCommand]
        Task Back() => NavigationService.NavigateToAsync("..");

    }
}
