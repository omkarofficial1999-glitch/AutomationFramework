using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        // Home page locators
        private By SignupLoginButton => By.XPath("//a[@href='/login']");
        private By Logo => By.XPath("//img[@alt='Website for automation practice']");

        // Login page locators
        private By EmailInput => By.XPath("//input[@data-qa='login-email']");
        private By PasswordInput => By.XPath("//input[@data-qa='login-password']");
        private By LoginButton => By.XPath("//button[@data-qa='login-button']");
        private By ErrorMessage => By.XPath("//p[contains(text(),'Your email or password is incorrect')]");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Home page methods
        public bool IsLogoVisible()
        {
            return _driver.FindElement(Logo).Displayed;
        }

        public void ClickSignupLogin()
        {
            _driver.FindElement(SignupLoginButton).Click();
        }

        // Login page methods
        public void EnterEmail(string email)
        {
            _driver.FindElement(EmailInput).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public bool IsErrorMessageVisible()
        {
            return _driver.FindElement(ErrorMessage).Displayed;
        }
    }
}