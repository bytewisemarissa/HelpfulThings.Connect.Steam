using System;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using HelpfulThings.Connect.Steam.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using HelpfulThings.Connect.Steam.IOC;
using HelpfulThings.Connect.Steam.Metering;
using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public abstract class BaseLiveTest
    {
        protected readonly ServiceProvider TestServiceProvider;
        
        protected BaseLiveTest()
        {
            string apiKey;

            try
            {
                apiKey = File.ReadAllText("ApiKey.Private");
            }
            catch (Exception ex)
            {
                throw new Exception("Problems loading the ApiKey.Private file. See the read me for help.", ex);
            }

            IServiceCollection testContainer = new ServiceCollection();

            testContainer.ConfigureSteamClient(options =>
            {
                options.ApiKey = apiKey;
                options.MeteringType = MeteringType.EvenSplit;
                options.MeteringPeriodHours = 24;
                options.RequestLimit = 100000;
                options.UserAgent = "HelpfulThings.Connect.Steam.Tests.Live";
                options.UserAgentVersion = "0.0.1";
            });

            TestServiceProvider = testContainer.BuildServiceProvider();
        }
    }
}