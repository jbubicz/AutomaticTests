using AutomationTest1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace AutomationTest1.StepDefinitions
{
    [Binding]
    public class TestingFormSteps
    {
        AutomationTestingFormPage automationTestingFormPage;
        public TestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Given(@"I navigate to the Blue Sky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();
        }
        
        [When(@"I ener the Single Line Text")]
        public void WhenIEnerTheSingleLineText()
        {
        }
        
        [When(@"I select One in the Select box")]
        public void WhenISelectOneInTheSelectBox()
        {
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
        }
        
        [When(@"I select United Kingdom at Country")]
        public void WhenISelectUnitedKingdomAtCountry()
        {
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int p0)
        {
        }
        
        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
        }
        
        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string message)
        {
        }
    }
}
