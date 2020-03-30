using Aquality.Selenium.Browsers;
using NUnit.Framework;

[assembly: LevelOfParallelism(3)]

namespace Nunit.Aquality.BasicAuthorizationTesting.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class Test
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
            BrowserManager.Browser.Quit();
        }
    }
}