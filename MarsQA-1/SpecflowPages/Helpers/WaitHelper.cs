using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.Helpers
{
    class WaitHelper
    {
        public static void WaitClickble(IWebDriver driver, IWebElement element)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0,0,15));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static bool CheckClickable(IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
