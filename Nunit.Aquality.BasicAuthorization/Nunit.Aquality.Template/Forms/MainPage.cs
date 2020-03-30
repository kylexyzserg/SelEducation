using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using Newtonsoft.Json;
using Nunit.Aquality.BasicAuthorizationTesting.Models;
using OpenQA.Selenium;

namespace Nunit.Aquality.BasicAuthorizationTesting.Forms
{
    public class MainPage : Form
    {
        private ILabel ResponseWrap => ElementFactory.GetLabel(By.XPath("//pre[contains(@style,'wrap')]"), "Response Wrap");

        public MainPage() : base(By.XPath("//pre[contains(@style,'word-wrap')]"), "Main page")
        {
        }

        public AuthenticatedUser GetAuthenticatedUser()
        {
            var response = ResponseWrap.GetText();
            var authenticatedUser = JsonConvert.DeserializeObject<AuthenticatedUser>(response);
            return authenticatedUser;
        }
    }
}