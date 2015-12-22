using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkDeleteLeadsGroups : DriverTestCase
    {
        [TestMethod]
        public void bulkdeleteleadsgroups()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadGroupAddNewPageHelper = new LeadGroupAddNewPageHelper(GetWebDriver());
            var LeadsGroupIndexPageHelper = new LeadsGroupIndexPageHelper(GetWebDriver());


            //Variable

            var TestGroup = "Test Group" + RandomNumber(1, 99);
            var TestCity = "Test City" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadGroupAddNewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadGroupAddNewPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadGroupAddNewPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadGroupAddNewPageHelper.WaitForWorkAround(7000);

//################### ADD NEW GROUP #########################


            //Click on Groups Add New
            LeadGroupAddNewPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            LeadGroupAddNewPageHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            LeadGroupAddNewPageHelper.TypeText("EnterCity", TestCity);

            //Select State
            LeadGroupAddNewPageHelper.Select("SelectState", "CT");

            //Select Country
            LeadGroupAddNewPageHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            LeadGroupAddNewPageHelper.TypeText("EnterZipCode", "85623");


            
            //Click On Groups
            LeadGroupAddNewPageHelper.ClickElement("ClickOnSave");
            LeadGroupAddNewPageHelper.WaitForWorkAround(10000);



//################### BULK DELETE GROUPS #########################


            //Search Company Name
            LeadsGroupIndexPageHelper.TypeText("EnterSearchFilterBox", TestGroup);
            LeadsGroupIndexPageHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            LeadsGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            LeadsGroupIndexPageHelper.MouseHover("locator");

            //Click On Delete Lead Groups
            LeadsGroupIndexPageHelper.ClickElement("ClickOnDeleteLeadGroups");
            LeadsGroupIndexPageHelper.WaitForWorkAround(4000);

            LeadsGroupIndexPageHelper.AcceptAlert();
            LeadsGroupIndexPageHelper.WaitForWorkAround(10000);






        }
    }
}
