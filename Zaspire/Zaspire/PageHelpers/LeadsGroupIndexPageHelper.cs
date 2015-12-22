﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.PageHelpers.Com
{
    public class LeadsGroupIndexPageHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public LeadsGroupIndexPageHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("LeadsGroupIndexPage.xml");
        }

        // ###########################  XML  ##############


        //Type into given xml node
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
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

        //Click 

        public void ClickElement(string xmlNode)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            WaitForElementPresent(locator, 20);
            Click(locator);
            WaitForWorkAround(3000);

        }

        public void DudlicateClick()
        {
            //var Save = "//*[@id='LeadCreateForm']/div[2]/div[3]/a[1]/span[1]";
            //var Dublicate = "//*[@id='message']/div[4]/div/a[1]/span[2]";
            var Save = "//*[@id='LeadCreateForm']/div[2]/div/ul/li[5]/button";
            var Dublicate = "//*[@id='message']/div[3]/div/div[8]/div/div/button";
            Click(Save);
            WaitForWorkAround(3000);

            if (IsElementPresent(Dublicate))
            {
                Click(Dublicate);
                WaitForWorkAround(3000);
            }
        }


        //Verify method Present method

        public void verifytext(System.Boolean flag, string Company)
        {
            //  var locator = locatorReader.ReadLocator(Company);
            if (flag == true)
            {
                Assert.IsTrue(IsElementPresent(Company));
            }
            else
            {
                Assert.IsFalse(IsElementPresent(Company));
            }

        }




        public void MouseHover(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='lead_groups_wrapper']/div[1]/div/div/button"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseOver(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='lead_groups']/tbody/tr[1]/td[2]/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        
    }
}