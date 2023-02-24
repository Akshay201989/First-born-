using Firstborn.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Firstborn.pages
{
    public class homegape
    {
        public void GoToTMPage(IWebDriver chrome)
        {
            
            IWebElement administriondropdown = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administriondropdown.Click();
            Thread.Sleep(500);

            IWebElement tmoption = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

        }
    }
}
 