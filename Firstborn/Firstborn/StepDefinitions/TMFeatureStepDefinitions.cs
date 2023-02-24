using Firstborn.pages;
using Firstborn.utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Firstborn.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : commondriver
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            chrome = new ChromeDriver();
            loginpage loginpageobj = new loginpage();
            loginpageobj.LogInActions(chrome);

        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homegape HomePageObj = new homegape();
            HomePageObj.GoToTMPage(chrome);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tmpage TmPageOBJ = new tmpage();
            TmPageOBJ.CreateTM(chrome);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            
        }
    }
}
