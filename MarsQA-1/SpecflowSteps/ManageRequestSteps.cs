using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class ManageRequestSteps
    {
        [Given(@"the User has received a new request")]
        public void GivenTheUserHasReceivedANewRequest()
        {
            ManageRequestPage.GenerateNewRequest();
        }

        [When(@"the User clicks on the received request menu option")]
        public void WhenTheUserClicksOnTheReceivedRequestMenuOption()
        {
            ManageRequestPage.NavigateToReceivedRequest();
        }

        [When(@"the User Accepts the new request")]
        public void WhenTheUserAcceptsTheNewRequest()
        {
            ManageRequestPage.AcceptRequest();
        }

        [When(@"the User Declines the new request")]
        public void WhenTheUserDeclinesTheNewRequest()
        {
            ManageRequestPage.DeclineRequest();
        }


        [Then(@"the User should see the received request")]
        public void ThenTheUserShouldSeeTheReceivedRequest()
        {
            ManageRequestPage.CheckReceivedRequest();
        }

        [Then(@"the User should see an alert on the Manage Request page")]
        public void ThenTheUserShouldSeeAnAlertOnTheManageRequestPage()
        {
            ManageRequestPage.CheckAlert();
        }

        [Then(@"the User should see the ""(.*)"" status on the request status")]
        public void ThenTheUserShouldSeeTheStatusOnTheRequestStatus(string Status)
        {
            ManageRequestPage.CheckNewRequestStatus(Status);
        }



    }
}
