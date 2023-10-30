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
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            
            loginPageObj.LoginActions(driver);

        }

        [Given(@"I navigate to Time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
          
            tmPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
          

            string newCode = tmPageObj.GetCode(driver);

            Assert.That(newCode == "aug2", "Actual code and existing code do not match");
            tmPageObj.CloseSteps(driver);
        }

        [When(@"I update '([^']*)' and '([^']*)' on an existing time record")]
        public void WhenIUpdateAndOnAnExistingTimeRecord(string p0, string p1)
        {
            tmPageObj.EditTimeRecord(driver, p0, p1);
        }

        [Then(@"the record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveUpdatedAnd(string p0, string p1)
        {
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedDescription = tmPageObj.GetEditedDescription(driver);

            Assert.That(editedCode == p0, "Actual code and existing code do not match");
            Assert.That(editedDescription == p1, "Actual description and existing description do not match");
            tmPageObj.CloseSteps(driver);
        }


    }
}
