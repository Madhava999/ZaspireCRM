using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using OpenQA.Selenium.Interactions;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.PageHelpers.Comm
{
    public class AccountsMoreActionsHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public AccountsMoreActionsHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("AccountsMoreActionsNotes.xml");
        }
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
        }
        public void ClickElement(string XmlNode)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            WaitForElementPresent(locator, 20);
            Click(locator);
            WaitForWorkAround(4000);
        }
          //Click on Name link
        public void OpenAccount()
        {
            var locator = locatorReader.ReadLocator("FirstClientNameLink");
            Click(locator);
        }

        //Click on Add Note button
        public void ClickAddNote()
        {
            var locator = locatorReader.ReadLocator("AddNote");
            Click(locator);
        }
        public void ClickLogACall()
        {
            var locator = locatorReader.ReadLocator("LogACall");
            Click(locator);
        }

        public void ClickAddFile()
        {
            var locator = locatorReader.ReadLocator("AddFile");
            Click(locator);
        }
        //Enter Note Subject
        public void EnterNoteSubject(string NoteSubject)
        {
            var locator = locatorReader.ReadLocator("NoteName");
            SendKeys(locator, NoteSubject);
        }
        //Select by value
        public void Select(string xmlNode, string value)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            SelectDropDown(locator, value);
        }

        //Enter Note Subject
        public void EnterFileSubject(string NoteSubject)
        {
            var locator = locatorReader.ReadLocator("FileName");
            SendKeys(locator, NoteSubject);
        }
        //Enter Note description
        public void EnterDesc(string Desc)
        {

            var locator = locatorReader.ReadLocator("Desc");
            SendKeys(locator, Desc);

        }
        public void ClickSend()
        {
            var locator = locatorReader.ReadLocator("Send");
            Click(locator);
        }
       /* public void EnterFileDesc(string NoteDesc)
        {

            var locator = locatorReader.ReadLocator("FileDesc");
            SendKeys(locator, NoteDesc);

        }*/

        public void VerifyText(string XmlNode, string text)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            var value = GetText(locator);
            Assert.IsTrue(value.Contains(text));
        }

        public void ClickButtonText()
        {
            var locator = locatorReader.ReadLocator("Save");
            Click(locator);
        }

        public void MouseOver(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[1]/div/ul/li[4]/div/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

    }
}



