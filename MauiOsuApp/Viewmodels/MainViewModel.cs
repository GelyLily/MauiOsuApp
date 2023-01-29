using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiOsuApp.Services.Navigation;

namespace MauiOsuApp
{

    public sealed record CountChangedMessage(string Text);
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string message = "Click me";

        public INavigationService NavigationService { get; private set; }

        public MainViewModel(INavigationService navigationService)
        {

        }
        
        [RelayCommand]
        private async Task NavigateProfile()
        {
            await MauiNavigationService.NavigateToAsync("//Profile");
            
        }
    }
}
