// open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.CompilerServices;

IWebDriver chrome = new ChromeDriver();
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

//check if user have logged in sucessfully
IWebElement check = chrome.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (check.Text == "Hello hari!")
{
    Console.WriteLine("pass");

}
else
{
    Console.WriteLine("le akshay ab fail hua");
}