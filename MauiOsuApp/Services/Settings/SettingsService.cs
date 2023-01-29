using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiOsuApp.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private const string AccessToken = "access_token";

        private readonly string AccessTokenDefault = string.Empty;


        public string AuthAccessToken
        {
            get => Preferences.Get(AccessToken, AccessTokenDefault);
            set => Preferences.Set(AccessToken, value);
        }
    }
}
