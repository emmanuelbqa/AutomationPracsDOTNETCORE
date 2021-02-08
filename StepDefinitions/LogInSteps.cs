using AutomationPracsDOTNETCORE.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationPracsDOTNETCORE.StepDefinitions
{
    [Binding]
    public sealed class LogInSteps : BasePage
    {
        HomePage homePage = new HomePage(_driver);
        SignInPage signInPage = new SignInPage(_driver);

        [Given(@"I navigate to Automation Practice Homepage")]
        public void GivenINavigateToAutomationPracticeHomepage()
        {
            LaunchSite();

        }

        [Given(@"I click on Sign In on the main menu")]
        public void GivenIClickOnSignInOnTheMainMenu()
        {
            homePage.ClickOnMenuSignInButton();

        }

        [When(@"enter ""(.*)"" as email address")]
        public void WhenEnterAsEmailAddress(string email)
        {
            signInPage.EnterEmail(email);

        }

        [When(@"I enter ""(.*)"" as password")]
        public void WhenIEnterAsPassword(string password)
        {
            signInPage.EnterPassword(password);
        }

        [When(@"I click on Sign In button")]
        public void WhenIClickOnSignInButton()
        {
            signInPage.ClickSignInButton();
        }

        [Then(@"the error message reads ""(.*)""")]
        public void ThenTheErrorMessageReads(string error)
        {
            signInPage.AssertErrorMesage(error);
        }

    }
}
