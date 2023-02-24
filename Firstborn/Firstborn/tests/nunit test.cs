using Firstborn.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Firstborn.tests
{
    public class nunit_test
    {
        IWebDriver chrome = new ChromeDriver();

        //login page object intialization and definition

        loginpage loginpageobj = new loginpage();
        loginpageobj.LogInActions(chrome);

        homegape HomePageObj = new homegape();
        HomePageObj.GoToTMPage(chrome);

        tmpage TmPageOBJ = new tmpage();
        TmPageOBJ.CreateTM(chrome);

        TmPageOBJ.EditTM(chrome);

    }
}
