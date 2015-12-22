using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddPositionsForLeadsGroup : DriverTestCase
    {
        [TestMethod]
        public void addpositionsforleadsgroup()
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

            //Variable

            var JobTitle = "Test Job" + RandomNumber(1, 99);
            var JobCity = "Test City" + RandomNumber(1, 99);


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



//################### ADD JOB POSITIONS  #########################


            //Click on Add Job Positions
            //LeadsGroupViewHelper.ClickElement("ClickOnAddPosition");

            //Enter Job Title
            LeadsGroupViewHelper.TypeText("EnterJobTitle", JobTitle);

            //Select Career Level
            LeadsGroupViewHelper.Select("SelectCareerLevel", "Lead Role");

            //Enter Exp Years
            LeadsGroupViewHelper.TypeText("EnterExpYears", "3");

            //Enter Exp Months
            LeadsGroupViewHelper.TypeText("EnterExpMonths", "5");

            //Enter Position Url
            LeadsGroupViewHelper.TypeText("EnterPositionUrl", "www.jobtitle.com");

            //Select Education
            LeadsGroupViewHelper.Select("SelectEducation", "B.Tech");

            //Click On Job Type Expand Icon
            LeadsGroupViewHelper.ClickElement("ClickOnJobTypeExpand");

            //Select Job Type
            LeadsGroupViewHelper.Select("SelectJobType", "Full Time");

            //Click On Job Location Expand Icon
            LeadsGroupViewHelper.ClickElement("ClickOnJobLocationExpand");

            //Enter City
            LeadsGroupViewHelper.TypeText("EnterCity", JobCity);

            //Select State
            LeadsGroupViewHelper.Select("SelectState", "DE");

            //Select Country
            LeadsGroupViewHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            LeadsGroupViewHelper.TypeText("EnterZipCode", "58962");


            //Click On Save
            LeadsGroupViewHelper.ClickElement("ClickOnSave");
            LeadsGroupViewHelper.WaitForWorkAround(10000);





        }
    }
}
