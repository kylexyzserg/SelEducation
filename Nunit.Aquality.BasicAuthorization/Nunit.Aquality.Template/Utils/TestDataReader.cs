using System.Reflection;
using Aquality.Selenium.Utilities;
using Nunit.Aquality.BasicAuthorizationTesting.ProjectConfigurations;

namespace Nunit.Aquality.BasicAuthorizationTesting.Utils
{
    public static class TestDataReader
    {
        public static T GetModel<T>(string jsonPath)
        {
            var json = new JsonFile($"Resources.Environment.{EnvironmentUtil.GetCurrentEnvironment()}.testData.json", Assembly.GetCallingAssembly());
            return json.GetValue<T>(jsonPath);
        }
    }
}