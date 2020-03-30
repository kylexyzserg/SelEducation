using Nunit.Aquality.BasicAuthorizationTesting.Forms;
using Nunit.Aquality.BasicAuthorizationTesting.Models;
using NUnit.Framework;

namespace Nunit.Aquality.BasicAuthorizationTesting.Steps
{
    public class MainPageSteps 
    {
        private readonly MainPage MainPage = new MainPage();
        public void CheckIfUserIsAuthorized(User user)
        {
            var authenticatedUser = MainPage.GetAuthenticatedUser();
            Assert.AreEqual(user.UserName, authenticatedUser.User, $"User {user.UserName} is not authorized");
            Assert.IsTrue(authenticatedUser.IsAuthenticated, "Authorization is not allowed");
        }
    }
}