using Courseworkmuyibabz.PageObjects;
using Courseworkmuyibabz.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Courseworkmuyibabz.StepDefinations
{
    [Binding]
    public class LoginSteps : Hooks
    {
        LoginPage loginPage;

        public LoginSteps()

        {
            loginPage = new LoginPage
        }

        [Given(@"I navigate to the giftrete")]
        public void GivenINavigateToTheGiftrete()
        {
            Hooks.Driver.Navigate().GoToUrl("https://giftrete.com/");
        }
        
        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.clicklogin();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
          loginPage.TypeEmail();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.clickSignin();
        }
        
        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            FluentAssertions.
        }
    }
}
