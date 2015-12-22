using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using OpenQA.Selenium.Interactions;
using Zaspire.PageHelpers.Comm;


namespace Zaspire.PageHelpers.Comm
{
    public class HomedashboardHelper: DriverHelper
    {
        public LocatorReader locatorReader;

        public HomedashboardHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("HomeDashboard.xml");
        }

        //Click to given xml node
        public void ClickElement(string XmlNode)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            WaitForElementPresent(locator, 20);
            Click(locator);
            WaitForWorkAround(4000);
        }

        //Type into given xml node
        public void TypeText(string XmlNode, string text)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
        }

        //Verify text of given xml node
        public void VerifyText(string XmlNode, string text)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            var value = GetText(locator);
            Assert.IsTrue(value.Contains(text));
        }

        //Select by value
        public void Select(string xmlNode, string value)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            SelectDropDown(locator, value);
        }

        internal void Upload(string Field, string FileName)
        {
            var locator = locatorReader.ReadLocator(Field);
            Console.WriteLine(FileName);
            GetWebDriver().FindElement(ByLocator(locator)).SendKeys(FileName);
            WaitForWorkAround(3000);
        }


        public void drawSign()
        {
            GetWebDriver().FindElement(By.XPath("//*[@id='signatureDiv']/div[1]/div[4]/canvas")).Click();
            //  GetWebDriver().FindElement(ByLocator("//*[@id='signatureDiv']/div[1]/div[4]/canvas")).Click();
        }

        //Click Dublicate
        public void ClickOnDublicate()
        {
            var locator = "//*[@id='ClientCreateForm']/div[2]/div[3]/div/a[1]/span[1]";
            var dublicate = "//*[@id='messageduplicate']/div[4]/div/a[1]/span[1]";
            Click(locator);
            WaitForWorkAround(3000);

            if (IsElementPresent(dublicate))
            {

                Click(dublicate);
                WaitForWorkAround(3000);

            }


        }
        public void MouseOver(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[3]/div[2]/div/div[1]/div[2]/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseHover(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[3]/div[1]/div/div[1]/div[2]/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }
        public void MouseHover1(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='dashboardDashboardType']/a/span[2]"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }
        public void MouseHover2(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[3]/div[1]/div/div[1]/div[2]/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }
        public void MouseHover3(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[3]/div[1]/div/div[1]/div[2]/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }



    }
}
