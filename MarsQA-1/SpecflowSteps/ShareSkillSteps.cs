using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class ShareSkillFeatureSteps
    {
        [When(@"the User clicks on the ShareSkill button")]
        public void WhenTheUserClicksOnTheShareSkillButton()
        {
            ProfilePages.GoToShareSkill();
        }
        
        [When(@"the user fills the ShareSkill form")]
        public void WhenTheUserFillsTheShareSkillForm()
        {
            ShareSkillPage.FillShareSkill(2);
        }
        
        [Then(@"the User should be able to see the skill on the Manage Listing page")]
        public void ThenTheUserShouldBeAbleToSeeTheSkillOnTheManageListingPage()
        {
            ManageListingPage.CheckListing(2);
        }

        [Given(@"the User navigates to the Manage Listing Page")]
        public void GivenTheUserNavigatesToTheManageListingPage()
        {
            ProfilePages.GoToManageListing();
        }

        [When(@"the User clicks the Edit button of a Shared Skill")]
        public void WhenTheUserClicksTheEditButtonOfASharedSkill()
        {
            ManageListingPage.EditListing();
            ShareSkillPage.EditShareSkill(3);
        }

        [Then(@"the User should be able to see the edited Skill on the Manage Listing page")]
        public void ThenTheUserShouldBeAbleToSeeTheEditedSkillOnTheManageListingPage()
        {
            ManageListingPage.CheckListing(3);
        }

        [When(@"the User clicks the Delete button of a Shared Skill")]
        public void WhenTheUserClicksTheDeleteButtonOfASharedSkill()
        {
            ManageListingPage.DeleteListing();
        }

        [Then(@"the User shouldn't be able to see the deleted Skill on the Manage Listing page")]
        public void ThenTheUserShouldnTBeAbleToSeeTheDeletedSkillOnTheManageListingPage()
        {
            ManageListingPage.CompareLastEntry();
        }


    }
}
