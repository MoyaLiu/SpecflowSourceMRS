using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class ChatSteps
    {
        [Given(@"The user has logged in")]
        public void GivenTheUserHasLoggedIn()
        {
            SignIn.OpenForm();
            SignIn.FillCredentials(7);
        }
        
        [Given(@"Clicks on Chat button")]
        public void GivenClicksOnChatButton()
        {
            //Click on Chat
            ChatPage.ClickOnChat();
        }
        
        [Given(@"Types in a message")]
        public void GivenTypesInAMessage()
        {
            //Type in and send a message on chat
            ChatPage.TypeAndSendMessage();
        }
        
       
        [When(@"Clicks on Chat button")]
        public void WhenClicksOnChatButton()
        {
            //Click on Chat
            ChatPage.ClickOnChat();
        }
        
        [When(@"Clicks on send button")]
        public void WhenClicksOnSendButton()
        {
            ChatPage.SendMessageButton();
        }

        [Then(@"User should be able to see the number of new messages")]
        public void ThenUserShouldBeAbleToSeeTheNumberOfNewMessages()
        {
            ChatPage.NumberOfMessagesAssertion();
        }


        [Then(@"User should be able to see Chat Dashboard")]
        public void ThenUserShouldBeAbleToSeeChatDashboard()
        {
            ChatPage.AbleToClickOnChatAssertion();
        }
        
        [Then(@"User should be able to see the message sent in the chat room")]
        public void ThenUserShouldBeAbleToSeeTheMessageSentInTheChatRoom()
        {
            ChatPage.SendMessageAssertion();
        }
        
        [Then(@"User should be able to see other users")]
        public void ThenUserShouldBeAbleToSeeOtherUsers()
        {
            ChatPage.AbleToClickUsernameAssertion();
        }
    }
}
