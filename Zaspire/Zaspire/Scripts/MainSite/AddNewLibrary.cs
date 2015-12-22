using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewLibrary : DriverTestCase
    {
        [TestMethod]
        public void addnewlibrary()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewLibraryHelper = new AddNewLibraryHelper(GetWebDriver());

            //Variable

            var DocumentName = "Test Library" + RandomNumber(1, 99);
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Events
            AddNewLibraryHelper.ClickElement("ClickOnLibrary");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries");
            //AddNewLibraryHelper.WaitForWorkAround(7000);


            //#################### CREATE A LIBRARY   #####################################

            //Create on Library
            AddNewLibraryHelper.ClickElement("ClickOnAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries/addnew");
            


            //################### CLASSIFICATIONS & OWNERSHIP  #########################


            //Select Library Category
            AddNewLibraryHelper.Select("LibraryCategory", "8921");

            //Select Library Owner  
            AddNewLibraryHelper.Select("SelectLibraryOwner", "1");

            //Enter Document Name
            AddNewLibraryHelper.TypeText("EnterDocumentName", DocumentName);

            //Select Document Type
            AddNewLibraryHelper.Select("SelectDocumentType", "Invoice");

            //Enter Library Version
            AddNewLibraryHelper.TypeText("EnterLibraryVersion", "5");

            
            //Click On Save
            AddNewLibraryHelper.ClickElement("ClickOnSave");
            AddNewLibraryHelper.WaitForWorkAround(7000);














        }
    }
}