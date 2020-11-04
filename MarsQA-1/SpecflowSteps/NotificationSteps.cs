using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public sealed class NotificationSteps
    {
        public string DashBoardUrl = "http://localhost:5000/Account/Dashboard";
        NotificationPage notification = null;
        Page page = null;
        NotificationSteps()
        {
            notification = new NotificationPage();
            page = new Page();
        }
        #region notification-menu
        [When(@"Click on the Notification button")]
        public void WhenClickOnTheNotificationButton()
        {
            notification.ClickNotificationButton();
        }

        [Then(@"The Notification should be displayed")]
        public void ThenTheNotificationShouldBeDisplayed()
        {
            Assert.IsTrue(notification.getServiceRequestText().Contains("Updated at"));
        }

        [Given(@"Click on the Notification button")]
        public void GivenClickOnTheNotificationButton()
        {
            notification.ClickNotificationButton();
        }

        [When(@"Click on the Mark all as read button")]
        public void WhenClickOnTheMarkAllAsReadButton()
        {
            notification.ClickMarkAllAsReadButton();
        }

        [Then(@"The numbers of notification should be cleared")]
        public void ThenTheNumbersOfNotificationShouldBeCleared()
        {
            Assert.IsTrue(!notification.isNumberVisible());
        }

        [When(@"Click on the See all button")]
        public void WhenClickOnTheSeeAllButton()
        {
            notification.ClickSeeAllButton();
        }

        [Then(@"The user should be able to navigate to the dashboard page")]
        public void ThenTheUserShouldBeAbleToNavigateToTheDashboardPage()
        {
            Assert.AreEqual(DashBoardUrl, Driver.driver.Url);
        }
        #endregion
        #region notification-dashboard
        [Given(@"Click on the See all button")]
        public void GivenClickOnTheSeeAllButton()
        {
            notification.ClickSeeAllButton();
        }

        [When(@"Click on the Load More button")]
        public void WhenClickOnTheLoadMoreButton()
        {
            notification.ClickLoadMoreButton();
        }

        [Then(@"The Show Less button should be displayed")]
        public void ThenTheShowLessButtonShouldBeDisplayed()
        {
            Assert.IsTrue(notification.isShowLessButtonVisible());
        }

        [Given(@"Click on the Load More button")]
        public void GivenClickOnTheLoadMoreButton()
        {
            notification.ClickLoadMoreButton();
        }

        [When(@"Click on the Show Less button")]
        public void WhenClickOnTheShowLessButton()
        {
            notification.ClickShowLessButton();
        }

        [Then(@"The Show Less button should be not displayed")]
        public void ThenTheShowLessButtonShouldBeNotDisplayed()
        {
            Assert.IsTrue(!notification.isShowLessButtonVisible());
        }

        [Given(@"Tick a notification item")]
        public void GivenTickANotificationItem()
        {
            notification.TickNotificationItem(0);
        }

        [When(@"Click on the Delete Selection icon")]
        public void WhenClickOnTheDeleteSelectionIcon()
        {
            notification.ClickDelectSelectionButton();
        }

        [Then(@"The notification item should be deleted")]
        public void ThenTheNotificationItemShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", page.getAlertDialogText());
        }

        [Given(@"Tick more than one notification items")]
        public void GivenTickMoreThanOneNotificationItems()
        {
            notification.TickNotificationItem(0);
            notification.TickNotificationItem(1);
        }

        [Then(@"The notification items should be deleted")]
        public void ThenTheNotificationItemsShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", page.getAlertDialogText());
        }

        [Given(@"Click on Select All icon")]
        public void GivenClickOnSelectAllIcon()
        {
            notification.ClickSelectAllButton();
        }

        [Then(@"All of the notification items should be deleted")]
        public void ThenAllOfTheNotificationItemsShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", page.getAlertDialogText());
            //Assert.AreEqual("You have no notifications", notification.getNoNotificationText());
        }
        #endregion


    }
}
