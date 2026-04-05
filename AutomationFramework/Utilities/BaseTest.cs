using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.Utilities
{
    public class BaseTest
    {
        protected IWebDriver Driver = null!;

        [SetUp]
        public void Setup()
        {
            Driver = DriverManager.GetDriver();
            Driver.Navigate().GoToUrl("https://automationexercise.com");
        }

        [TearDown]
        public void TearDown()
        {
            Driver?.Dispose();
            DriverManager.QuitDriver();
        }
    }
}