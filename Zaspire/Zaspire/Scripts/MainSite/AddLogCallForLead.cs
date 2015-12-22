using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddLogCallForLead : DriverTestCase
    {
        [TestMethod]
        public void addlogcallforlead()
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

            var CallSubject = "Test Call" + RandomNumber(1, 99);


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


            
//#################### ADD LOG CALL   #####################################



            //Click On Log Call
            AddEventsForLeadHelper.ClickElement("ClickOnAddCall");

            //Enter Call Subject
            AddEventsForLeadHelper.TypeText("EnterCallSubject", CallSubject);

            //Select Call Type
            AddEventsForLeadHelper.Select("SelectCallType", "Inbound");

            //Enter Call Date
            AddEventsForLeadHelper.TypeText("EnterCallDate", "");

            //Select Call From
            //AddEventsForLeadHelper.Select("SelectCallFrom", "");

            //Select Call To
            //AddEventsForLeadHelper.Select("SelectCallTo", "");

            //Enter Call From Number
            AddEventsForLeadHelper.TypeText("EnterCallFromNumber", "8713120369");

            //Enter Call To Number
            AddEventsForLeadHelper.TypeText("EnterCallToNumber", "9856512369");

            //Enter Call Hours
            AddEventsForLeadHelper.TypeText("EnterCallHours", "00");

            //Enter Call Minutes
            AddEventsForLeadHelper.TypeText("EnterCallMins", "25");

            //Enter Call Secs
            AddEventsForLeadHelper.TypeText("EnterCallSecs", "45");

            //Click on Description Link
            AddEventsForLeadHelper.ClickElement("ClickOnDescriptionLink");

            //Enter Call Description
            AddEventsForLeadHelper.TypeText("EnterCallDescription", "This is Log Call Description");
            

            
            //Click On Save
            AddEventsForLeadHelper.ClickElement("ClickOnSaveLogCall");
            AddEventsForLeadHelper.WaitForWorkAround(7000);



        }
    }
}