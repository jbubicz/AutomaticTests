using OpenQA.Selenium;
using AutomationTest1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTest1.PageObjects

{
    class AutomationTestingFormPage
    {
        IWebDriver driver;

        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
        }

        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
        }
    }
}
