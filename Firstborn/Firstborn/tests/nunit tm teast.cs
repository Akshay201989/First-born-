using Firstborn.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using Firstborn.utilities;

namespace Firstborn.tests
{
    [TestFixture]
    public class nunit_tm_teast : commondriver
    {

        [SetUp]
        public void loginsteps()
        {
            chrome = new ChromeDriver();
            //login page object intialization and definition

            loginpage loginpageobj = new loginpage();
            loginpageobj.LogInActions(chrome);

            homegape HomePageObj = new homegape();
            HomePageObj.GoToTMPage(chrome);

        }

        [Test,Order(1),Description("we can create TM test")]
        public void CreateTM_test()
        {
            tmpage TmPageOBJ = new tmpage();
            TmPageOBJ.CreateTM(chrome);

        }

        [Test,Order(2)]
        public void EditTM_TEst()
        {
            tmpage TmPageOBJ = new tmpage();
            TmPageOBJ.EditTM(chrome);
        }

        [Test,Order(3)]
        public void DeleteTM_Test()
        {
            tmpage TmPageOBJ = new tmpage();
            TmPageOBJ.DeleteTM(chrome);
        }

        [TearDown]
        public void CloseTM_TEst()
        {
            chrome.Quit();
        }

         


        
    
        
        

        

        
          
    }
}
