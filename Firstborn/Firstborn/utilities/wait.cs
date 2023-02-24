using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstborn.utilities
{
    internal class wait
    {
        public static void WaitForElementToBeClickable(IWebDriver chrome, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(chrome, new TimeSpan(0, 0, seconds));
            if (locator == "xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));

            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }


        }
        public static void WaitForElementToBeExist(IWebDriver chrome, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(chrome, new TimeSpan(0, 0, seconds));
            if (locator == "xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
            }
            if (locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));

            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorvalue)));
            }


        }
    }
}
