using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void leadsindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsIndexPageActionsHelper = new LeadsIndexPageActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsIndexPageActionsHelper.ClickElement("ClickOnLeads");
            LeadsIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on Filter By Groups
            LeadsIndexPageActionsHelper.ClickElement("ClickOnFilterByGroups");

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Select Filter By Groups
            LeadsIndexPageActionsHelper.Select("SelectFilterByGroups", "");

            //Click On Custom Views
            LeadsIndexPageActionsHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Click On Custom Views New
            LeadsIndexPageActionsHelper.ClickElement("ClickOnCustomViewsNew");

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Select Custom Views
            LeadsIndexPageActionsHelper.Select("SelectCustomViews", "");

            //Select Default Views
            LeadsIndexPageActionsHelper.Select("SelectDefaultViews", "My Leads");

            //Enter Tags
            LeadsIndexPageActionsHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            LeadsIndexPageActionsHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            LeadsIndexPageActionsHelper.ClickElement("ClockOnTagsReset");

            //Enter Filter Search
            LeadsIndexPageActionsHelper.TypeText("EnterFilterSearch", "New");
            LeadsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            LeadsIndexPageActionsHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            LeadsIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            LeadsIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Lead Name Link
            LeadsIndexPageActionsHelper.ClickElement("FirstLeadNameLink");

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLookView");
            LeadsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLookEdit");
            LeadsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            LeadsIndexPageActionsHelper.ClickElement("ClockOnQuickLookDelete");

            LeadsIndexPageActionsHelper.AcceptAlert();
            LeadsIndexPageActionsHelper.WaitForWorkAround(10000);








        }
    }
}