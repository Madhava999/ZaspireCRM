using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddLeadsForGroupView : DriverTestCase
    {
        [TestMethod]
        public void addleadsforgroupview()
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


//################### ADD LEADS FOR GROUPS VIEW PAGE  #########################


            //Click on Add Leads
            LeadsGroupViewHelper.ClickElement("ClickOnAddLeads");

            //Select Pageination
            LeadsGroupViewHelper.Select("SelectPagination", "20");

            //Click on Master Check Box
            LeadsGroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click on Add To Group
            LeadsGroupViewHelper.ClickElement("ClickOnAddToGroup");


        }
    }
}