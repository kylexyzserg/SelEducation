using System.Reflection;
using Aquality.Selenium.Utilities;

namespace Nunit.Aquality.BasicAuthorizationTesting.ProjectConfigurations
{
    public class ProjectConfiguration
    {
        private static ProjectConfiguration Configuration;
        public JsonFile CurrentConfiguration { get; }
        public string StartUrl => CurrentConfiguration.GetValue<string>("startUrl");

        private ProjectConfiguration()
        {
            CurrentConfiguration = new JsonFile($"Resources.Environment.{EnvironmentUtil.GetCurrentEnvironment()}.config.json", Assembly.GetCallingAssembly());
        }

        public static ProjectConfiguration Instance
        {
            get
            {
                if (Configuration == null)
                {
                    return new ProjectConfiguration();
                }

                return Configuration;
            }
        }
    }
}