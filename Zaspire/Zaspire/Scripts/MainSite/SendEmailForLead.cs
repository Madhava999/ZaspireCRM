using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class SendEmailForLead : DriverTestCase
    {
        [TestMethod]
        public void sendemailforlead()
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
            AddEventsForLeadHelper.WaitForWorkAround(5000);



//################### SEND EMAIL  #########################


            //Click on Send Email
            AddEventsForLeadHelper.ClickElement("ClickOnSendEmail");

            //Click On Employees Link
            AddEventsForLeadHelper.ClickElement("ClickOnEmployeesLink");

            //Click On To Address Check Box
            AddEventsForLeadHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            AddEventsForLeadHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            AddEventsForLeadHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            AddEventsForLeadHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            AddEventsForLeadHelper.ClickElement("ClickOnSendEmailButton");
            AddEventsForLeadHelper.WaitForWorkAround(10000);
            

        }
    }
}