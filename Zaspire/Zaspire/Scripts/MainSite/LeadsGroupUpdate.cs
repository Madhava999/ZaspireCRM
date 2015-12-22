using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsGroupUpdate : DriverTestCase
    {
        [TestMethod]
        public void leadsgroupupdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsGroupUpdateHelper = new LeadsGroupUpdateHelper(GetWebDriver());


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
            LeadsGroupUpdateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsGroupUpdateHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadsGroupUpdateHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsGroupUpdateHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            LeadsGroupUpdateHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsGroupUpdateHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            LeadsGroupUpdateHelper.ClickElement("ClickOnEdit");

//################### GROUP UPDATE #########################


            //Enter Group Name
            LeadsGroupUpdateHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            LeadsGroupUpdateHelper.TypeText("EnterCity", TestCity);

            //Select State
            LeadsGroupUpdateHelper.Select("SelectState", "CA");

            //Select Country
            LeadsGroupUpdateHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            LeadsGroupUpdateHelper.TypeText("EnterZipCode", "74123");




            //Click On Groups
            LeadsGroupUpdateHelper.ClickElement("ClickOnSave");
            LeadsGroupUpdateHelper.WaitForWorkAround(10000);




        }
    }
}
