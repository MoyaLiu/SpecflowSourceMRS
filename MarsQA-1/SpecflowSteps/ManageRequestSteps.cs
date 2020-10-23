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
            ManageRequestPage.GenerateNewRequest(5);
        }

        [Given(@"the User sends a new request")]
        public void GivenTheUserHasSentANewRequest()
        {
            ManageRequestPage.GenerateNewRequest(2);
        }

        [Given(@"the request has been Accepted")]
        public void GivenTheRequestHasBeenAccepted()
        {
            ManageRequestPage.AcceptRequestWithOtherUser();
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

        [When(@"the User clicks on the Complete button")]
        public void WhenTheUserClicksOnTheCompleteButton()
        {
            ManageRequestPage.CompleteRequest();
        }

        [When(@"the User clicks on the Completed button")]
        public void WhenTheUserClicksOnTheCompletedButton()
        {
            ManageRequestPage.CompletedRequest();
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

        [When(@"the User clicks on the sent request menu option")]
        public void WhenTheUserClicksOnTheSentRequestMenuOption()
        {
            ManageRequestPage.NavigateToSentRequest();
        }

        [Then(@"the User should see the sent requests")]
        public void ThenTheUserShouldSeeTheSentRequests()
        {
            ManageRequestPage.CheckSentRequest();
        }

        [When(@"the User Withdraws the new request")]
        public void WhenTheUserWithdrawsTheNewRequest()
        {
            ManageRequestPage.WithdrawRequest();
        }

        [Then(@"the User should see the ""(.*)"" status on the sent request status")]
        public void ThenTheUserShouldSeeTheStatusOnTheSentRequestStatus(string status)
        {
            ManageRequestPage.CheckNewSentStatus(status);
        }


    }
}
