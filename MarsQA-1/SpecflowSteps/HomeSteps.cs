using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        [Given(@"Im in the Home Page")]
        public void GivenImInTheHomePage()
        {
            SignUp.CheckHomePage();
        }

        [When(@"I Click on the Join Button")]
        public void WhenIClickOnTheJoinButton()
        {
            SignUp.OpenForm();
        }

        [When(@"I Fill the form with my current Email")]
        public void WhenIFillTheFormWithMyCurrentEmail()
        {
            SignUp.Register(2);
        }

        [When(@"I Fill the form with invalid data")]
        public void WhenIFillTheFormWithInvalidData()
        {
            SignUp.Register(3);
            SignUp.CreateAlerts();
        }

        [Then(@"I should see an alert in the Email field")]
        public void ThenIShouldSeeAnAlertInTheEmailField()
        {
            SignUp.CheckRepeatedEmailAlert();
        }

        [Then(@"I should see an alert in every field")]
        public void ThenIShouldSeeAnAlertInEveryField()
        {
            SignUp.CheckAllFieldAlerts();
        }

        [Then(@"I should see the Register form")]
        public void ThenIShouldSeeTheRegisterForm()
        {
            SignUp.CheckFormPresence();
        }

    }
}
