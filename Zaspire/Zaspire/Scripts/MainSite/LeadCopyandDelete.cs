using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class LeadCopyandDelete : DriverTestCase
    {
        [TestMethod]
        public void leadcopyanddelete()
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
            AddEventsForLeadHelper.WaitForWorkAround(10000);


            
//#################### LEAD COPY  #####################################



            //Click on Copy
            AddEventsForLeadHelper.ClickElement("ClickOnCopy");
            AddEventsForLeadHelper.WaitForWorkAround(5000);

            AddEventsForLeadHelper.AcceptAlert();
            AddEventsForLeadHelper.WaitForWorkAround(5000);


//#################### LEAD DELETE  #####################################


            //Click on Delete
            AddEventsForLeadHelper.ClickElement("ClickOnDelete");
            AddEventsForLeadHelper.WaitForWorkAround(5000);

            AddEventsForLeadHelper.AcceptAlert();
            AddEventsForLeadHelper.WaitForWorkAround(5000);

            


        }
    }
}