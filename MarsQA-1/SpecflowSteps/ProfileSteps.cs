using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class ProfileSteps
    {
        //Common Profile Steps
        [Given(@"the User is in the Profile page")]
        public void GivenTheUserIsInTheProfilePage()
        {
            ProfilePage.GoToProfilePage();
            ProfilePage.CheckProfilePage();
        }

        [Given(@"the User has log-In")]
        public void GivenTheUserHasLog_In()
        {
            SignIn.SigninStep();
        }
        
        //Add new details Function
        [When(@"the User fills the profile details")]
        public void WhenTheUserFillsTheProfileDetails()
        {
            ProfilePage.FillDetails(2);
        }
        
        [Then(@"the User is able to see the profile details in the profile page")]
        public void ThenTheUserIsAbleToSeeTheProfileDetailsInTheProfilePage()
        {
            ProfilePage.CheckDetails(2);
        }

        //Edit details Function
        [When(@"the User edits the profile details")]
        public void WhenTheUserEditsTheProfileDetails()
        {
            ProfilePage.EditDetails(3);
        }

        [Then(@"the User is able to see the changed details in the profile page")]
        public void ThenTheUserIsAbleToSeeTheChangedDetailsInTheProfilePage()
        {
            ProfilePage.CheckDetails(3);
        }

        //Delete details Function
        [When(@"the User deletes the profile details")]
        public void WhenTheUserDeletesTheProfileDetails()
        {
            ProfilePage.DeleteDetails();
        }

        [Then(@"the User is not able to see the profile details in the profile page")]
        public void ThenTheUserIsnTAbleToSeeTheProfileDetailsInTheProfilePage()
        {
            ProfilePage.CheckIfEmpty();
        }
    }
}
