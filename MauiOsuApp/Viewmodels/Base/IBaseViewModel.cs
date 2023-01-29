using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiOsuApp.Services.Navigation;
using MauiOsuApp.Services.Settings;

namespace MauiOsuApp.ViewModels.Base
{
    public interface IBaseViewModel : IQueryAttributable
    {
        public INavigationService NavigationService { get; }
        public ISettingsService SettingsService { get; }

        public bool IsBusy { get; }

        public bool IsInitialized { get; set; }

        Task InitializeAsync();
    }
}
