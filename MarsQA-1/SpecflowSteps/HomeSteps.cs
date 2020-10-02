using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
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

        [When(@"I Click on the SignIn Button")]
        public void WhenIClickOnTheSignInButton()
        {
            SignIn.OpenForm();
        }

        [When(@"I Fill the form with an unregistered Email")]
        public void WhenIFillTheFormWithAnUnregisteredEmail()
        {
            SignIn.FillCredentials(3);
        }

        [Then(@"I should see a Confirm Email form")]
        public void ThenIShouldSeeAConfirmEmailForm()
        {
            //ScenarioContext.Current.Pending();

        }

        [When(@"I Fill the form with valid credentials")]
        public void WhenIFillTheFormWithValidCredentials()
        {
            SignIn.FillCredentials(2);
        }

        [Then(@"I should see the Profile page")]
        public void ThenIShouldSeeTheProfilePage()
        {
            ProfilePages.CheckProfilePage();
        }


    }
}
