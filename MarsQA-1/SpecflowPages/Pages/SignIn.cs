using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }
        public static void Login(string account,string password)
        {
            Driver.NavigateUrl();

            //Enter Log-In function
            SignInBtn.Click();

            //Enter Username
            Email.SendKeys(account);

            //Enter password
            Password.SendKeys(password);

            //Click on Login Button
            LoginBtn.Click();

        }
        public static void CheckLogin()
        {
            //Driver.driver.FindElement(By.Xpath)
        }
    }
}