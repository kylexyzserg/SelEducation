using Aquality.Selenium.Browsers;
using Aquality.Selenium.Logging;
using Nunit.Aquality.BasicAuthorizationTesting.Models;
using Nunit.Aquality.BasicAuthorizationTesting.ProjectConfigurations;
using Nunit.Aquality.BasicAuthorizationTesting.Steps;
using Nunit.Aquality.BasicAuthorizationTesting.Utils;
using NUnit.Framework;

namespace Nunit.Aquality.BasicAuthorizationTesting.Tests
{
    public class BasicAuthorizationTest : Test
    {
        private readonly MainPageSteps MainPageSteps = new MainPageSteps();
        private static readonly User User = TestDataReader.GetModel<User>("user");
        private readonly string Url = string.Format(ProjectConfiguration.Instance.StartUrl, User.UserName, User.Password);       

        [Test]
        public void Authorization()
        {           
            Logger.Instance.Info("Step 1. Go through basic authorization");
            BrowserManager.Browser.GoTo(Url);
            MainPageSteps.CheckIfUserIsAuthorized(User);
        }
    }
}