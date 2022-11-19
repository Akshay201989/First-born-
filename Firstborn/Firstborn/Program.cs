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
    Console.WriteLine("yeah baby we did it");

}
else
{
    Console.WriteLine("NO NO NOT AGAIN");
}
// navigate to time and material
IWebElement administriondropdown = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administriondropdown.Click();
Thread.Sleep(500);

IWebElement tmoption = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();

// click on create new button
Thread.Sleep(1500);

IWebElement createnewbutton = chrome.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewbutton.Click();
Thread.Sleep(1000);

//select time in the typecode dropdown
IWebElement typecodedropdown = chrome.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typecodedropdown.Click();

IWebElement timeoption = chrome.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
timeoption.Click();

//enter code in code textbox
IWebElement codetextbox = chrome.FindElement(By.Id("Code"));
codetextbox.SendKeys("firstborn");

// enter desxription in the description box
IWebElement descriptiontextbox = chrome.FindElement(By.Id("Description"));
descriptiontextbox.SendKeys("firstborn");

// eter price in the price unitbox
IWebElement overlapping = chrome.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
overlapping.Click();
IWebElement pricetextbox = chrome.FindElement(By.Id("Price"));
pricetextbox.SendKeys("100$ ");

//click on save button
IWebElement save = chrome.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
save.Click();
Thread.Sleep(2000);

//go to the last page
IWebElement lastpage = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
lastpage.Click();

IWebElement newcode = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));

if(newcode.Text == "firstborn")
{
    Console.WriteLine("finally firstborn born");
}
else
{ Console.WriteLine("it was a false alarm");
}
