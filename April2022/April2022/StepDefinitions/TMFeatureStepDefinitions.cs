using April2022.Pages;
using April2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace April2022.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        // Page objects initialization
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tMPageObj = new TMPage();

        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialzation and definition
            
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initialzation and definition
            
            tMPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tMPageObj.GetCode(driver);
            string newTypeCode = tMPageObj.GetTypeCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);


            Assert.That(newCode == "April2022", "Actual code and expected code do not match.");
            Assert.That(newTypeCode == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(newDescription == "April2022", "Actual description and expcted description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match.");
        }

        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            tMPageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string p0, string p1, string p2)
        {
            string editedDescription = tMPageObj.GetEditedDescription(driver);
            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedPrice = tMPageObj.GetEditedPrice(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not match.");
            Assert.That(editedCode == p1, "Actual code and expected code do not match.");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match.");
        }


    }

}

