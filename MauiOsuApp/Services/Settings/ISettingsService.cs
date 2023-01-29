using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiOsuApp.Services.Settings
{
    public interface ISettingsService
    {
        string AuthAccessToken { get; set; }
    }
}
