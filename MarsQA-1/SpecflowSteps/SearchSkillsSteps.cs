using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public sealed class SearchSkillsSteps
    {
        [Given(@"the User is at Login Page")]
        public void GivenTheUserIsAtLoginPage()
        {
            SignIn.OpenForm();
            SignIn.FillCredentials(2);
        }

        [When(@"User Input text in search skill Textbox")]
        public void WhenUserInputTextInSearchSkillTextbox()
        {
            SearchSkills.EnterText(2);
            SearchSkills.ClickOnSearchButton();
        }

        [Then(@"User is able to see Result")]
        public void ThenUserIsAbleToSeeResult()
        {
            //assertion
            SearchSkills.CheckSearchSkills(2);
        }

        [When(@"I Click on Search icon")]
        public void WhenIClickOnSearchIcon()
        {
            SearchSkills.ClickOnSearchButton();
        }

        [When(@"Select Category then Sub-Categories")]
        public void WhenSelectCategoryThenSub_Categories()
        {
            SearchSkills.ClickOnCategory(3);
        }

        [Then(@"I should see all record of sub-categories")]
        public void ThenIShouldSeeAllRecordOfSub_Categories()
        {
            //assertion
            SearchSkills.CheckSubCategory();
        }


        [When(@"I Enter Username")]
        public void WhenIEnterUsername()
        {
            SearchSkills.EnterUserName(5);
        }

        [Then(@"I should see all skill of that user")]
        public void ThenIShouldSeeAllSkillOfThatUser()
        {
            SearchSkills.CheckSkillByUsername(5);
        }


        [When(@"I click on Online button")]
        public void WhenIClickOnOnlineButton()
        {
            SearchSkills.ClickOnOnline();
        }

        [Then(@"I should see all online skills")]
        public void ThenIShouldSeeAllOnlineSkills()
        {
            //Assertion
            SearchSkills.CheckClickOnOnline();
        }


        [When(@"I click on Onsite button")]
        public void WhenIClickOnOnsiteButton()
        {
            SearchSkills.ClickOnOnsite();
        }

        [Then(@"I should see all onsite skills")]
        public void ThenIShouldSeeAllOnsiteSkills()
        {
            SearchSkills.CheckClickOnsite();
        }



        [When(@"I click on Show All button")]
        public void WhenIClickOnShowAllButton()
        {
            SearchSkills.ClickOnShowAll();
        }

        [Then(@"I should see all skills")]
        public void ThenIShouldSeeAllSkills()
        {
            SearchSkills.CheckLastPage();
        }

    }
}
