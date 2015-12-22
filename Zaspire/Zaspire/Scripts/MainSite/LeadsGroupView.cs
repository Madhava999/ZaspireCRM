using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsGroupView : DriverTestCase
    {
        [TestMethod]
        public void leadsgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsGroupViewHelper = new LeadsGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadsGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            LeadsGroupViewHelper.ClickElement("FirstLeadGroupNameLink");

            
//################### GROUPS VIEW PAGE ACTIONS  #########################


            //Click on Add New
            LeadsGroupViewHelper.ClickElement("ClickOnAddNew");

            //Click On Add New To Groups
            LeadsGroupViewHelper.ClickElement("ClickOnAddNewToGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            //LeadsGroupViewHelper.WaitForWorkAround(7000);

            //Click on Edit
            LeadsGroupViewHelper.ClickElement("ClickOnEdit");

            //Click On Edit To Groups
            LeadsGroupViewHelper.ClickElement("ClickOnEditToGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            //LeadsGroupViewHelper.WaitForWorkAround(7000);

            //Click on Back
            LeadsGroupViewHelper.ClickElement("ClickOnBack");

            //Click On Groups
            //LeadsGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupViewHelper.WaitForWorkAround(7000);

            //Click on More Actions
            LeadsGroupViewHelper.ClickElement("ClickOnMoreActions");

            //Click on Delete
            LeadsGroupViewHelper.ClickElement("ClickOnDelete");
            LeadsGroupViewHelper.WaitForWorkAround(4000);

            LeadsGroupViewHelper.AcceptAlert();
            LeadsGroupViewHelper.WaitForWorkAround(10000);


//################### JOB POSITIONS SEARCH FOR GROUPS VIEW PAGE  #########################


            //Enter Job Positions Search Box
            LeadsGroupViewHelper.TypeText("EnterJobPositionsSearchBox", "Java Developer");

            //Click On Job Positions Reset Button
            LeadsGroupViewHelper.ClickElement("ClickOnJobPositionsReset");


//################### LEADS SEARCH FOR GROUP VIEW PAGE  #########################


            //Enter Leads Search Box
            LeadsGroupViewHelper.TypeText("EnterLeadsSearchBox", "Test Lead");

            //Click On Leads Reset Button
            LeadsGroupViewHelper.ClickElement("ClickOnLeadsReset");





        }
    }
}
