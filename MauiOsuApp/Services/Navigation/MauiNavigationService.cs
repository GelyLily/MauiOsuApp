using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiOsuApp.Services.Settings;
using MauiOsuApp.Views;

namespace MauiOsuApp.Services.Navigation
{
    public class MauiNavigationService : INavigationService
    {
        private readonly ISettingsService _settingsService;

        public MauiNavigationService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public Task InitializeAsync() =>
            NavigateToAsync(
                string.IsNullOrEmpty(_settingsService.AuthAccessToken)
                    ? "//" + nameof(MainPage)
                    : "//" + nameof(MainPage));

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            return
                routeParameters != null
                    ? Shell.Current.GoToAsync(route, routeParameters)
                    : Shell.Current.GoToAsync(route);
        }

        public Task PopAsync() =>
            Shell.Current.GoToAsync("..");
    }
}
