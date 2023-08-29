using August2023.Pages;
using August2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace August2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions :  CommonDriver
    {
        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

        }

        [Given(@"I navigate to Time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetCode(driver);

            Assert.That(newCode == "aug2", "Actual code and existing code do not match");
        }

        [When(@"I update '([^']*)' on an existing time record")]
        public void WhenIUpdateOnAnExistingTimeRecord(string p0)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver, p0);
        }

        [Then(@"the record should have updated '([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0)
        {
            TMPage tmPageObj = new TMPage();

            string editedCode = tmPageObj.GetEditedCode(driver);
            Assert.That(editedCode ==  p0, "Actual code and expected code do not match");
        }


    }
}
