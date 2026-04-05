using NUnit.Framework;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;

namespace AutomationFramework.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage _homePage = null!;

        [SetUp]
        public new void Setup()
        {
            base.Setup();
            _homePage = new HomePage(Driver);
        }

        [Test]
        public void HomePageLoads_LogoIsVisible()
        {
            Assert.That(_homePage.IsLogoVisible(), Is.True,
                "Home page logo should be visible");
        }

        [Test]
        public void ClickSignupLogin_NavigatesToLoginPage()
        {
            _homePage.ClickSignupLogin();
            Assert.That(Driver.Url, Does.Contain("/login"),
                "Clicking signup should navigate to login page");
        }

        [Test]
        public void Login_WithInvalidCredentials_ShowsError()
        {
            // Go to login page
            _homePage.ClickSignupLogin();

            // Enter wrong email and password
            _homePage.EnterEmail("wrongemail@test.com");
            _homePage.EnterPassword("wrongpassword");

            // Click login
            _homePage.ClickLoginButton();

            // Check error message appears
            Assert.That(_homePage.IsErrorMessageVisible(), Is.True,
                "Error message should appear for invalid login");
        }

        [Test]
        public void Login_WithEmptyFields_StaysOnLoginPage()
        {
            // Go to login page
            _homePage.ClickSignupLogin();

            // Click login without entering anything
            _homePage.ClickLoginButton();

            // Should stay on login page
            Assert.That(Driver.Url, Does.Contain("/login"),
                "Should stay on login page when fields are empty");
        }
    }
}