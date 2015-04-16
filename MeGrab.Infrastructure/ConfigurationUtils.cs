using Eagle.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MeGrab.Infrastructure
{
    public static class ConfigurationUtils
    {
        public static string PassportServiceUrl
        {
            get
            {
                return GetAppSettingsConfigValue("SSOPassportServiceUrl", 
                                                 "http://passport.wq.com/api/PassportService/GetTokenCredential/");
            }
        }

        public static string GetAppSettingsConfigValue(string key, string defaultValue = "")
        {
            string configValue = ConfigurationManager.AppSettings[key];

            if (!configValue.HasValue())
            {
                return defaultValue;
            }

            return configValue;
        }
    }
}
