using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WebAdvert.SearchWorker
{
    public static class ConfigurationHelper
    {
        private static IConfiguration _configuration = null;

        public static IConfiguration Instance {
            get {
                if (_configuration == null)
                {
                    _configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectort())
                        .AddJsonFile("appsettings.json").Build();
                }

                return _configuration;
            }
        }
    }
}