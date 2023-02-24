using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Firstborn.pages
{
    public class loginpage
    {
        public void LogInActions(IWebDriver chrome)
        {
            
            chrome.Manage().Window.Maximize();

            //launch turnup portal
            chrome.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username
            IWebElement usernametextbox = chrome.FindElement(By.Id("UserName"));
            usernametextbox.SendKeys("hari");
            //identify password textbox and valid password
            IWebElement passwordtextbox = chrome.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");

            //click login button
            IWebElement clicklogin = chrome.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            clicklogin.Click();

        }
    }
}
