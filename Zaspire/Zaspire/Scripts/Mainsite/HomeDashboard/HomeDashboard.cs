using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class Home_Dashboard : DriverTestCase
    {
        [TestMethod]
        public void HomeDashboard()
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
            HomedashboardHelper HomedashboardHelper = new HomedashboardHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            HomedashboardHelper.WaitForWorkAround(4000);

           HomedashboardHelper.ClickElement("ClickOnLeads");
            HomedashboardHelper.WaitForWorkAround(4000);

            HomedashboardHelper.ClickElement("ClickOnHome");

            HomedashboardHelper.ClickElement("ClickOnContacts");
            HomedashboardHelper.WaitForWorkAround(4000);

            HomedashboardHelper.ClickElement("ClickOnHome");

            HomedashboardHelper.ClickElement("ClickOnAccounts");
            HomedashboardHelper.WaitForWorkAround(4000);

            HomedashboardHelper.ClickElement("ClickOnHome");

            HomedashboardHelper.ClickElement("ClickOnOpportunities");
            HomedashboardHelper.WaitForWorkAround(4000);
            HomedashboardHelper.ClickElement("ClickOnHome");

            HomedashboardHelper.ClickElement("ClickOnCampaigns");
            HomedashboardHelper.WaitForWorkAround(4000);
            HomedashboardHelper.ClickElement("ClickOnHome");

            HomedashboardHelper.ClickElement("ClickOnPartners");
            HomedashboardHelper.WaitForWorkAround(4000);

            HomedashboardHelper.ClickElement("ClickOnHome");

//############################ Modules modified by day

            HomedashboardHelper.MouseHover("Locator");

            HomedashboardHelper.ClickElement("ModulesModifiedByDay");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ActivitiesModifiedByDay");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ModulesCreatedByDay");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ActivitiesCreatedByDay");
            HomedashboardHelper.WaitForWorkAround(2000);

//############################ Upcoming Events

            HomedashboardHelper.MouseOver("Locator");

            HomedashboardHelper.ClickElement("ClickOnUpcoming");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ClickOnPastDue");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ClickOnAll");
            HomedashboardHelper.WaitForWorkAround(2000);

            HomedashboardHelper.ClickElement("ClickOnCalendar");
            HomedashboardHelper.WaitForWorkAround(2000);
        

//######################## Dashboard

            HomedashboardHelper.MouseHover1("Locator");

            HomedashboardHelper.ClickElement("SelectCRMDashboard");

            HomedashboardHelper.ClickElement("SelectATSDashboard");

//###################### Teams

            HomedashboardHelper.MouseHover2("Locator");

            HomedashboardHelper.ClickElement("ClickOnAllOption");

            HomedashboardHelper.ClickElement("ClickOnMyTeamOption");

            HomedashboardHelper.ClickElement("ClickOnMyOption");

//################### Activity Stream

            HomedashboardHelper.ClickElement("OwnerLink");

            HomedashboardHelper.ClickElement("GroupLink");

            HomedashboardHelper.ClickElement("FileLink");

//################## Form Date Range

            HomedashboardHelper.Select("DateRange", "This Week");



        }

    }
}