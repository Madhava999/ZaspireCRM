using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ViewPageJobPositions : DriverTestCase
    {
        [TestMethod]
        public void View_Page_Job_Postions()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);


            //Click to open client info
            AddAccountHelper.ClickElement("SelectClient");

            AddAccountHelper.ClickElement("ClickJobPositions");
            AddAccountHelper.WaitForWorkAround(1000);

            AddAccountHelper.ClickElement("ClickOnAddNewButton");

            AddAccountHelper.TypeText("EnterJobType", "Java Developer");

            //AddAccountHelper.ClickElement("ClickOnCareerLevel");

            AddAccountHelper.Select("SelectCareerLevel", "Entry");

            AddAccountHelper.TypeText("SelectExperienceYears", "3");

            AddAccountHelper.TypeText("SelectExperienceMonths", "5");

            AddAccountHelper.TypeText("EnterJobPositionURL", "https://www.jobposition.com");

            AddAccountHelper.ClickElement("ClickOnJobPositionSaveButton");
            AddAccountHelper.WaitForWorkAround(5000);

            AddAccountHelper.ClickElement("ClickJobPositions");

            
        }
    }
}