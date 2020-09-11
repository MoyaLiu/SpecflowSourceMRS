using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace IC_TimeMaterialPage.Helpers
{
    class WaitHelper
    {
        public static void WaitClickble(IWebDriver driver, IWebElement element)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0,0,30));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static bool CheckClickable(IWebDriver driver, IWebElement element)
        {
            try
            {
                var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
