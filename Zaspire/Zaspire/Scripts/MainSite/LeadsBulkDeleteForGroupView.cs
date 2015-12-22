using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsBulkDeleteForGroupView : DriverTestCase
    {
        [TestMethod]
        public void leadsbulkdeleteforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsBulkActionsForGroupViewHelper = new LeadsBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            LeadsBulkActionsForGroupViewHelper.ClickElement("FirstLeadGroupNameLink");


//################### BULK DELETE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            LeadsBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            LeadsBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Delete Leads
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteLeads");

            LeadsBulkActionsForGroupViewHelper.AcceptAlert();
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);




//################### DELETE LEAD FOR GROUPS VIEW  #########################


            //Click on Delete Lead
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteLead");

            LeadsBulkActionsForGroupViewHelper.AcceptAlert();
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);



        }
    }
}