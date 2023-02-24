using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Firstborn.pages
{
    public class tmpage
    {
        public void CreateTM(IWebDriver chrome)
        {
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

            // click on create new button
            Thread.Sleep(1500);

            IWebElement createnewbutton = chrome.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewbutton.Click();
            Thread.Sleep(1000);

            //select time in the typecode dropdown
            IWebElement typecodedropdown = chrome.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();
            Thread.Sleep(2000);

            IWebElement timeoption = chrome.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeoption.Click();

            //enter code in code textbox
            IWebElement codetextbox = chrome.FindElement(By.Id("Code"));
            codetextbox.SendKeys("firstborn");

            // enter desxription in the description box
            IWebElement descriptiontextbox = chrome.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("firstborn");

            // eter price in the price unitbox
            IWebElement overlapping = chrome.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
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
            Thread.Sleep(1000);

            //IWebElement newcode = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            //Example 2:
           // Assert.That(newcode.Text == "firstborn","Actual code and expected not match");
            // Example 2:
            //if (newcode.Text == "firstborn")
            //{
            //    Assert.Pass("finally firstborn born");
            //}
            //else
            //{
            //    Assert.Fail("it was a false alarm");
            //}
        }
        public string GetCode(IWebDriver chrome)
        {
            IWebElement actualCode = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        
        public void EditTM(IWebDriver chrome)
        {

            // click on edit of last row
            IWebElement edit = chrome.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edit.Click();
            Thread.Sleep(2000);
            //go to price change the valve
            IWebElement overlapping = chrome.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement pricetextbox = chrome.FindElement(By.Id("Price"));
            overlapping.Click();
            pricetextbox.Clear();
            
            overlapping.Click();
            pricetextbox.SendKeys("9");

            //save the result
            IWebElement save = chrome.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save.Click();
            Thread.Sleep(2000);
            IWebElement lastpage = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
            lastpage.Click();

            //check changed value
            IWebElement changedprice = chrome.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            IWebElement newcode = chrome.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode.Text == "$9.00")
            {
                Console.WriteLine("price changed");
            }
            else
            {
                Console.WriteLine("not changed");
            }

        }
        public void DeleteTM(IWebDriver chrome)
        {
            //click delete button
            IWebElement delete = chrome.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(2000);
            //clicking ok on pop up
            chrome.SwitchTo().Alert().Accept();
        }


    }
}
