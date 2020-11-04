using MarsQA_1.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class SanitySteps
    {
        [Given(@"the User find an interesting skill")]
        public void GivenTheUserFindAnInterestingSkill()
        {
            //LogIn
            SignIn.OpenForm();
            SignIn.FillCredentials(2);

            //Check if user is able to click on search icon
            SearchSkills.ClickOnSearchButton();

            //Check if user is able to input username
            SearchSkills.EnterUserName(4);

            //Check if user can open a Skill Box
            SearchSkills.ClickOnOnFirstBox();

        }
        
        [Given(@"the User creates a new Skill to trade")]
        public void GivenTheUserCreatesANewSkillToTrade()
        {
            //LogIn
            SignIn.OpenForm();
            SignIn.FillCredentials(2);

            //Create a new skill to trade
            ProfilePages.GoToShareSkill();
            ShareSkillPage.FillShareSkill(2);
            Thread.Sleep(3000);

        }
        
        [Given(@"the Skill has been requested by a Learner")]
        public void GivenTheSkillHasBeenRequestedByALearner()
        {
            //LogsOut to allow the second user to request the Skill
            ProfilePages.LogOut();
            ManageRequestPage.GenerateNewRequest(5);
        }

        [When(@"the User request to trade the skill")]
        public void WhenTheUserRequestToTradeTheSkill()
        {
            //Sent a request for an already opened Skill
            ManageRequestPage.SentRequest();
        }
        
        [When(@"the Seller accepts the skill trade")]
        public void WhenTheSellerAcceptsTheSkillTrade()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"the User checks the notification")]
        public void WhenTheUserChecksTheNotification()
        {
            //LogIn with the main account
            SignIn.OpenForm();
            SignIn.FillCredentials(2);
        }
        
        [When(@"the User accepts the skill trade")]
        public void WhenTheUserAcceptsTheSkillTrade()
        {
            //Navigate to Manage Received Request and accepts the Trade
            ManageRequestPage.NavigateToReceivedRequest();
            ManageRequestPage.AcceptRequest();
        }
    }
}
