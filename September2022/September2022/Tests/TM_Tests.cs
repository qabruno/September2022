using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2022.Pages;
using September2022.Utilities;

namespace September2022.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            // open chrome browser

            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
