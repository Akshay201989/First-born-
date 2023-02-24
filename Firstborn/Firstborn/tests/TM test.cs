using Firstborn.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Firstborn.utilities;

        IWebDriver chrome = new ChromeDriver();

        
        //login page object intialization and definition

        loginpage loginpageobj = new loginpage();
        loginpageobj.LogInActions(chrome);

        homegape HomePageObj = new homegape();
        HomePageObj.GoToTMPage(chrome);
    
        tmpage TmPageOBJ = new tmpage();
        TmPageOBJ.CreateTM(chrome);

        TmPageOBJ.EditTM(chrome);

        TmPageOBJ.DeleteTM(chrome);

        chrome.Quit();
          
   
