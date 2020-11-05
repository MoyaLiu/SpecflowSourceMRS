using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class NotificationPage
    {
        #region elements
        private IWebElement NotificationButton => Driver.driver.FindElement(By.XPath("//div[contains(@class,'ui top left pointing dropdown item')]"));
        private IWebElement MarkAllAsRead => Driver.driver.FindElement(By.XPath("//div/center/a[text() = 'Mark all as read']"));
        private IWebElement SeeAll => Driver.driver.FindElement(By.XPath("//div/center/a[@href]"));
        private IWebElement LoadMore => Driver.driver.FindElement(By.XPath("//a[@class = 'ui button'][text() = 'Load More...']"));
        private IWebElement ShowLess => Driver.driver.FindElement(By.XPath("//a[@class = 'ui button'][text() = '...Show Less']"));
        private IWebElement SelectAll => Driver.driver.FindElement(By.XPath("//div[@class = 'ui icon basic button'][@data-tooltip = 'Select all']"));
        private IWebElement DeleteSelection => Driver.driver.FindElement(By.XPath("//div[@class = 'ui icon basic button'][@data-tooltip = 'Delete selection']"));
        #endregion

        #region locators
        private By ServiceRequest = By.XPath("//div[@class = 'extra']/div[@id = 'myDIV']");
        private By ShowLessLocator = By.XPath("//a[@class = 'ui button'][text() = '...Show Less']");
        private By NumberLocator = By.XPath("//div[@class = 'floating ui blue label']");
        private By NoNotificationLocator = By.XPath("//div[@class = 'ui items segment']/span/div[@class = 'item']");
        #endregion

        #region methods
        internal void ClickNotificationButton()
        {
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(NotificationButton).Perform();
            Thread.Sleep(2000);

        }
        internal void ClickMarkAllAsReadButton()
        {
            WaitHelper.WaitClickble(Driver.driver, MarkAllAsRead);
            MarkAllAsRead.Click();
        }
        internal void ClickSeeAllButton()
        {
            WaitHelper.WaitClickble(Driver.driver, SeeAll);
            SeeAll.Click();
        }
        internal void ClickLoadMoreButton()
        {
            WaitHelper.WaitClickble(Driver.driver, LoadMore);
            LoadMore.Click();
        }
        internal void ClickShowLessButton()
        {
            WaitHelper.WaitClickble(Driver.driver, ShowLess);
            ShowLess.Click();
        }
        internal void ClickSelectAllButton()
        {
            WaitHelper.WaitClickble(Driver.driver, SelectAll);
            SelectAll.Click();
        }
        internal void ClickDelectSelectionButton()
        {
            WaitHelper.WaitClickble(Driver.driver, DeleteSelection);
            DeleteSelection.Click();
        }
        internal void TickNotificationItem(int i)
        {
            //i: The index of the notification item in the notification list
            var itemWebElement = "//input[@type = 'checkbox'][@value = '" + i.ToString() + "']";
            Console.WriteLine("item index is " + i + ", element locator path = " + itemWebElement);
            WaitHelper.WaitClickble(Driver.driver, By.XPath(itemWebElement), 5);
            Driver.driver.FindElement(By.XPath(itemWebElement)).Click();
        }
        #endregion

        #region assertion
        internal string getServiceRequestText()
        {
            WaitHelper.WaitVisible(Driver.driver, ServiceRequest, 5);
            return Driver.driver.FindElement(ServiceRequest).Text;
        }
        internal string getNoNotificationText()
        {
            WaitHelper.WaitVisible(Driver.driver, NoNotificationLocator, 5);
            return Driver.driver.FindElement(NoNotificationLocator).Text;
        }
        internal bool isShowLessButtonVisible()
        {
            return WaitHelper.WaitVisible(Driver.driver, ShowLessLocator, 5);
        }
        internal bool isNumberVisible()
        {
            Thread.Sleep(3000);
            return WaitHelper.WaitVisible(Driver.driver, NumberLocator, 2);
        }
        #endregion

    }
}
