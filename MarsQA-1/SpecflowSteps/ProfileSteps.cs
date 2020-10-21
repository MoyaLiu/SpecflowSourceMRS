using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.SpecflowPages.Pages.ProfilePage;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class ProfileSteps
    {
        [Given(@"the User has log-In")]
        public void GivenTheUserHasLog_In()
        {
            SignIn.OpenForm();
            SignIn.FillCredentials(2);
        }

        [When(@"the User edits the fluidcard details")]
        public void WhenTheUserEditsTheFluidcardDetails()
        {
            ProfilePages.EditName(2);
            ProfilePages.FillCardField();
        }

        [Then(@"the User is able to see the changes in the fluid card")]
        public void ThenTheUserIsAbleToSeeTheChangesInTheFluidCard()
        {
            ProfilePages.CheckName(2);
        }

        [When(@"the user fills the New Language details")]
        public void WhenTheUserFillsTheNewLanguageDetails()
        {
            LanguageTab.AddLanguage(2);
        }

        [Then(@"the User should see the new Language in his profile")]
        public void ThenTheUserShouldSeeTheNewLanguageInHisProfile()
        {
            LanguageTab.CheckLanguage(2);
        }

        [When(@"the user fills the Edit Language details")]
        public void WhenTheUserFillsTheEditLanguageDetails()
        {
            LanguageTab.EditLanguage(3);
        }

        [Then(@"the User should see the edited Language in his profile")]
        public void ThenTheUserShouldSeeTheEditedLanguageInHisProfile()
        {
            LanguageTab.CheckLanguage(3);
        }

        [When(@"the user deletes the Language")]
        public void WhenTheUserDeletesTheLanguage()
        {
            LanguageTab.DeleteLanguage();
        }

        [Then(@"the User should not see the Language in his profile")]
        public void ThenTheUserShouldNotSeeTheLanguageInHisProfile()
        {
            LanguageTab.CompareLastEntry();
        }

        [When(@"the user fills the New Skill details")]
        public void WhenTheUserFillsTheNewSkillDetails()
        {
            SkillsTab.AddSkill(2);
        }

        [Then(@"the User should see the new Skill in his profile")]
        public void ThenTheUserShouldSeeTheNewSkillInHisProfile()
        {
            SkillsTab.CheckSkill(2);
        }

        [When(@"the user fills the Edit Skill details")]
        public void WhenTheUserFillsTheEditSkillDetails()
        {
            SkillsTab.EditSkill(3);
        }

        [Then(@"the User should see the edited Skill in his profile")]
        public void ThenTheUserShouldSeeTheEditedSkillInHisProfile()
        {
            SkillsTab.CheckSkill(3);
        }

        [When(@"the user deletes the Skill")]
        public void WhenTheUserDeletesTheSkill()
        {
            SkillsTab.DeleteSkill();
        }

        [Then(@"the User should not see the Skill in his profile")]
        public void ThenTheUserShouldNotSeeTheSkillInHisProfile()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"the user fills the New Education details")]
        public void WhenTheUserFillsTheNewEducationDetails()
        {
            EducationTab.AddEducation(2);
        }

        [Then(@"the User should see the new Education in his profile")]
        public void ThenTheUserShouldSeeTheNewEducationInHisProfile()
        {
            EducationTab.CheckEducation(2);
        }

        [When(@"the user fills the Edit Education details")]
        public void WhenTheUserFillsTheEditEducationDetails()
        {
            EducationTab.EditEducation(3);
        }

        [Then(@"the User should see the edited Education in his profile")]
        public void ThenTheUserShouldSeeTheEditedEducationInHisProfile()
        {
            EducationTab.CheckEducation(3);
        }

        [When(@"the user deletes the Education")]
        public void WhenTheUserDeletesTheEducation()
        {
            EducationTab.DeleteEducation();
        }

        [Then(@"the User should not see the Education in his profile")]
        public void ThenTheUserShouldNotSeeTheEducationInHisProfile()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"the user fills the New Certificate details")]
        public void WhenTheUserFillsTheNewCertificateDetails()
        {
            CertificatesTab.AddCertificate(2);
        }

        [Then(@"the User should see the new Certificate in his profile")]
        public void ThenTheUserShouldSeeTheNewCertificateInHisProfile()
        {
            CertificatesTab.CheckCertificate(2);
        }

        [When(@"the user fills the Edit Certificate details")]
        public void WhenTheUserFillsTheEditCertificateDetails()
        {
            CertificatesTab.EditCertificate(3);
        }

        [Then(@"the User should see the edited Certificate in his profile")]
        public void ThenTheUserShouldSeeTheEditedCertificateInHisProfile()
        {
            CertificatesTab.CheckCertificate(3);
        }

        [When(@"the user deletes the Certificate")]
        public void WhenTheUserDeletesTheCertificate()
        {
            CertificatesTab.DeleteCertificate();
        }

        [Then(@"the User should not see the Certificate in his profile")]
        public void ThenTheUserShouldNotSeeTheCertificateInHisProfile()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"the User clicks the edit icon in the Profile description")]
        public void WhenTheUserClicksTheEditIconInTheProfileDescription()
        {
            ProfilePages.OpenDescriptionTextfield();
        }

        [When(@"the User fills the Profile description")]
        public void WhenTheUserFillsTheProfileDescription()
        {
            ProfilePages.FillDescription(2);
        }

        [Then(@"the User is able to see the description in the profile page")]
        public void ThenTheUserIsAbleToSeeTheDescriptionInTheProfilePage()
        {
            ProfilePages.CheckProfileDescription(2);
        }

        [When(@"the User clicks the change password option in the Profile menu")]
        public void WhenTheUserClicksTheChangePasswordOptionInTheProfileMenu()
        {
            ProfilePages.OpenChangePassword();
        }

        [When(@"the User fills the change password form with valid password")]
        public void WhenTheUserFillsTheChangePasswordFormWithValidData()
        {
            ChangePassword.FillForm(3);
        }

        [When(@"the User fills the change password form with invalid password")]
        public void WhenTheUserFillsTheChangePasswordFormWithInvalidData()
        {
            ChangePassword.FillForm(4);
        }

        [Then(@"the User is able to see an alert in the change password page")]
        public void ThenTheUserIsAbleToSeeAnAlertInTheChangePasswordPage()
        {
            ChangePassword.CheckAlert(2);
        }


        [Then(@"the User is able to log with the new data")]
        public void ThenTheUserIsAbleToLogWithTheNewData()
        {
            ChangePassword.CheckNewPassword();
        }


    }
}
