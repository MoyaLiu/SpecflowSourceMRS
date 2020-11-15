using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class Notification_DashboardSteps
    {
        [Given(@"the user has logged in")]
        public void GivenTheUserHasLoggedIn()
        {
            SignIn.OpenForm();
            SignIn.FillCredentials(7);
        }
        
        [Given(@"Click on Select all")]
        public void GivenClickOnSelectAll()
        {
            Notifications_Page.SelectAllServiceRequests();
        }
        
        [When(@"Click on Mark Selection as Read")]
        public void WhenClickOnMarkSelectionAsRead()
        {
            Notifications_Page.MarkSelection();
        }
        
      
        [When(@"Click on Select all")]
        public void WhenClickOnSelectAll()
        {
            Notifications_Page.SelectAllServiceRequests();
        }
        
        [When(@"Click on Unselect all")]
        public void WhenClickOnUnselectAll()
        {
            Notifications_Page.UnselectAllRequests();
        }
        
        [Then(@"The notification item should be marked as read")]
        public void ThenTheNotificationItemShouldBeMarkedAsRead()
        {
            Notifications_Page.MarkAsReadAssertion();
        }
        
        [Then(@"All notifications selected should be marked as read")]
        public void ThenAllNotificationsSelectedShouldBeMarkedAsRead()
        {
            Notifications_Page.MarkAsReadAssertion();
        }
        
        [Then(@"All notifications should be selected")]
        public void ThenAllNotificationsShouldBeSelected()
        {
            Notifications_Page.AllServiceRequestsSelectedAssertion();
        }
        
        [Then(@"All notifications should be unselected")]
        public void ThenAllNotificationsShouldBeUnselected()
        {
            Notifications_Page.UnselectAllAssertion();
        }
    }
}
