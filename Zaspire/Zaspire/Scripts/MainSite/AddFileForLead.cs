using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddFileForLead : DriverTestCase
    {
        [TestMethod]
        public void addfileforlead()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForLeadHelper = new AddEventsForLeadHelper(GetWebDriver());

            //Variable

            var FileName = "Test File" + RandomNumber(1, 99);
                      

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForLeadHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForLeadHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForLeadHelper.ClickElement("MoveHover");
            AddEventsForLeadHelper.WaitForWorkAround(10000);


//################### ADD FILE  #########################


            //Click on Add File
            AddEventsForLeadHelper.ClickElement("ClickOnAddFile");

            //Enter Note Subject
            AddEventsForLeadHelper.TypeText("EnterFileName", FileName);

            //Select Category
            AddEventsForLeadHelper.TypeText("SelectCategory", "9293");
            
            //Upload File 
            String Filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            AddEventsForLeadHelper.Upload("SelectAttachmentFile", Filename);
            AddEventsForLeadHelper.WaitForWorkAround(10000);

            //Enter File Description
            AddEventsForLeadHelper.TypeText("EnterFileDescription", "This is File Description");

            //Click On Save
            AddEventsForLeadHelper.ClickElement("ClickOnSaveFile");
            AddEventsForLeadHelper.WaitForWorkAround(7000);


            
        }
    }
}

