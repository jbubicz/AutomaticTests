using System;
using TechTalk.SpecFlow;

namespace AutomationTest1.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            Console.WriteLine("test");
        }
        
        [Given(@"I click on the Register button")]
        public void GivenIClickOnTheRegisterButton()
        {
        }
        
        [When(@"I enter the First name")]
        public void WhenIEnterTheFirstName()
        {
        }
        
        [When(@"I enter the Last name")]
        public void WhenIEnterTheLastName()
        {
        }
        
        [When(@"I enter the password")]
        public void WhenIEnterThePassword()
        {
        }
        
        [When(@"I enter the confirm password")]
        public void WhenIEnterTheConfirmPassword()
        {
        }
        
        [When(@"I click the Sign Up button")]
        public void WhenIClickTheSignUpButton()
        {
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
        }
    }
}
