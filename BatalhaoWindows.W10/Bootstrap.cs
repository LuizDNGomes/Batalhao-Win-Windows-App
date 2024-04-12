//---------------------------------------------------------------------------
//
// <copyright file="Bootstrap.cs" company="Microsoft">
//    Copyright (C) 2015 by Microsoft Corporation.  All rights reserved.
// </copyright>
//
// <createdOn>12/17/2016 7:40:58 PM</createdOn>
//
//---------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;
using Windows.Storage;

using AppStudio.Uwp;
using AppStudio.Uwp.Controls;

using BatalhaoWindows.Services;

namespace BatalhaoWindows
{
    static class Bootstrap
    {
        private static readonly Guid APP_ID = new Guid("f7f1ad7a-b2fe-48a8-8edc-c258e118f4f3");

		public static void Init()
        {
			InitializeTelemetry();
			InitializeTilesAsync().FireAndForget();

			BitmapCache.ClearCacheAsync(TimeSpan.FromHours(48)).FireAndForget();
		}

        private static async Task InitializeTilesAsync()
        {
            if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily.ToLower() != "windows.iot")
            {
                var init = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.TilesInitialized];
                if (init == null || (init is bool && !(bool)init))
                {
                    await TileServices.CreateLiveTile(@"Assets\Tiles\tiles.xml");
                    ApplicationData.Current.LocalSettings.Values[LocalSettingNames.TilesInitialized] = true;
                }
            }
        }

		private static void InitializeTelemetry()
        {
            var init = !string.IsNullOrEmpty(ApplicationData.Current.LocalSettings.Values[LocalSettingNames.DeviceType] as string);
            if (!init)
            {
                string deviceType = IsOnPhoneExecution() ? LocalSettingNames.PhoneValue : LocalSettingNames.WindowsValue;
                ApplicationData.Current.LocalSettings.Values[LocalSettingNames.DeviceType] = deviceType;
                ApplicationData.Current.LocalSettings.Values[LocalSettingNames.StoreId] = ValidateStoreId();
            }
        }

        private static bool IsOnPhoneExecution()
        {
            var qualifiers = Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().QualifierValues;
            return (qualifiers.ContainsKey("DeviceFamily") && qualifiers["DeviceFamily"] == "Mobile");
        }

        private static Guid ValidateStoreId()
        {
            try
            {
                Guid storeId = CurrentApp.AppId;
                if (storeId != Guid.Empty && storeId != APP_ID)
                {
                    return storeId;
                }

                return Guid.Empty;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }
    }
}