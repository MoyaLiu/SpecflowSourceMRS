using MarsQA_1.Feature;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
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
        }

        [Given(@"the User has log-In")]
        public void GivenTheUserHasLog_In()
        {
            SignIn.Login("limbo12_@hotmail.com","123123");
            ProfilePage.CheckProfilePage();
        }
        
        //Add new details Function
        [When(@"the User fills the profile details")]
        public void WhenTheUserFillsTheProfileDetails()
        {
            ProfilePage.FillDetails();
        }
        
        [Then(@"the User is able to see the profile details in the profile page")]
        public void ThenTheUserIsAbleToSeeTheProfileDetailsInTheProfilePage()
        {
            ProfilePage.CheckDetails("English", "Selenium", "Bachelor in Mechatronic Engineering", "Manual Handling");
        }

        //Edit details Function
        [When(@"the User edits the profile details")]
        public void WhenTheUserEditsTheProfileDetails()
        {
            ProfilePage.EditDetails();
        }

        [Then(@"the User is able to see the changed details in the profile page")]
        public void ThenTheUserIsAbleToSeeTheChangedDetailsInTheProfilePage()
        {
            ProfilePage.CheckDetails("English", "Selenium C#", "Bachelor in Mechatronic Engineering", "Manual Handling");
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
