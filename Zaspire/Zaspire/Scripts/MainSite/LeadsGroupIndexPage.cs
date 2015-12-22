using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsGroupIndexPage : DriverTestCase
    {
        [TestMethod]
        public void leadsgroupindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsGroupIndexPageHelper = new LeadsGroupIndexPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsGroupIndexPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsGroupIndexPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

//################### GROUPS INDEX PAGE ACTIONS #########################


            //Click on Groups Add New
            LeadsGroupIndexPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Click on Back To Lead Groups Index page
            LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            //LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Enter Search Filter Box 
            LeadsGroupIndexPageHelper.TypeText("EnterSearchFilterBox", "Test Group");
            LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            LeadsGroupIndexPageHelper.ClickElement("ClickOnFilterResetButton");
            LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            LeadsGroupIndexPageHelper.MouseHover("locator");

            //Click On Delete Lead Groups
            LeadsGroupIndexPageHelper.ClickElement("ClickOnDeleteLeadGroups");

            //Check Master Check Box
            LeadsGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            LeadsGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            LeadsGroupIndexPageHelper.MouseOver("locator");
            
            //Click On Quick Link
            LeadsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            LeadsGroupIndexPageHelper.ClickElement("ClickOnView");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            LeadsGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            LeadsGroupIndexPageHelper.ClickElement("ClickOnEdit");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            LeadsGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            LeadsGroupIndexPageHelper.ClickElement("ClickOnDelete");

            //Click On First Group Name
            LeadsGroupIndexPageHelper.ClickElement("ClickOnFirstGroupName");

            //Click on Back To Lead Groups Index page
            LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            //LeadsGroupIndexPageHelper.WaitForWorkAround(7000);





        }
    }
}