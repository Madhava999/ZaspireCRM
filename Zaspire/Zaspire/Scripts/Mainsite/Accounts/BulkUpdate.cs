using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    class Bulkupdate_Status
    {
        [TestClass]
        public class BulkUpdateStatus : DriverTestCase
        {
            [TestMethod]
            public void bulkUpdateStatus()
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
                BulkUpdateHelper BulkUpdateHelper = new BulkUpdateHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Click On Account Tab
                BulkUpdateHelper.ClickElement("ClickonAccountsTab");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Enter Account in search field
                BulkUpdateHelper.TypeText("SearchStatus", "New");
                BulkUpdateHelper.WaitForWorkAround(10000);

                //Click on Account
                BulkUpdateHelper.ClickElement("SelectMasterCheckbox");

                //Click on Delete
                //BulkUpdateHelper.ClickElement("SelectClient2");

                //Click on Bulk Update Button
                BulkUpdateHelper.MouseOver("Locator");
                

                BulkUpdateHelper.ClickElement("ClickonBulkUpdate");

                //Select Manager
                BulkUpdateHelper.Select("ClickOnManager", "51");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnPartner", "6");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnSource", "Campaign");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnOwner", "51");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnCategory", "20545");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnStatus", "New");
                BulkUpdateHelper.WaitForWorkAround(4000);




                //Click on Upadte Button
                BulkUpdateHelper.ClickElement("ClickOnUpadte");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Accept Alert
                BulkUpdateHelper.AcceptAlert();
                BulkUpdateHelper.WaitForWorkAround(8000);

          

            }
        }
    }
}
