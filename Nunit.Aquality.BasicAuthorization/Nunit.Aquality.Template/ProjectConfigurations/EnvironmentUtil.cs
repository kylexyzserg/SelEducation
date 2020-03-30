using System;
using System.Runtime.CompilerServices;
using Aquality.Selenium.Logging;

namespace Nunit.Aquality.BasicAuthorizationTesting.ProjectConfigurations
{
    public static class EnvironmentUtil
    {
        private static Environment currentEnvironment = Environment.Unknown;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Environment GetCurrentEnvironment()
        {
            if (currentEnvironment == Environment.Unknown)
            {
                const string defaultEnv = "stage";
                var environment = System.Environment.GetEnvironmentVariable("environment") ?? defaultEnv;
                if (!Enum.TryParse(environment, true, out currentEnvironment))
                {
                    Logger.Instance.Warn($"'{environment}' value cannot be parsed as Environment. Tests will be started on default '{defaultEnv}'");
                }
            }
            return currentEnvironment;
        }
    }

    public enum Environment
    {
        Unknown = 0,
        Prod,
        Stage
    }
}