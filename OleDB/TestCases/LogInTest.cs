using NUnit.Framework;
using OleDB.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace OleDB.TestCases
{
    class LogInTest
    {
            [Test]
            public void Test()
            {

                IWebDriver driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(10));
                driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new HomePage(driver);
            homePage.ClickOnMyAccount();

            var loginPage = new LoginPage(driver);
                loginPage.LoginToApplication("LogInTest");

                driver.Close();
        }
    }
}
