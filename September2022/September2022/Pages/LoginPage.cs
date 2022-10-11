using OpenQA.Selenium;
using September2022.Utilities;

namespace September2022.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            // navigate to TurnUp portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Wait.WaitToExist(driver, "Id", "UserName", 5);

            //Thread.Sleep(500);

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);

        }
    }
}
