using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;



namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class Index_Page_Quick_Links : DriverTestCase
    {
        [TestMethod]
        public void IndexPageQuickLinks()
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
            //BulkUpdateHelper.TypeText("SearchStatus", "New");
            //BulkUpdateHelper.WaitForWorkAround(10000);

            //Click on Account
            //BulkUpdateHelper.ClickElement("SelectMasterCheckbox");

            //Click on Delete
            //BulkUpdateHelper.ClickElement("SelectClient2");

            //Click on Bulk Update Button
            BulkUpdateHelper.MouseHover("Locator");

            BulkUpdateHelper.ClickElement("ClickOnQuickLinks");
            BulkUpdateHelper.WaitForWorkAround(1000);

            BulkUpdateHelper.ClickElement("ClickOnViewButton");
            BulkUpdateHelper.WaitForWorkAround(4000);

            BulkUpdateHelper.ClickElement("AccountsLink");
            BulkUpdateHelper.WaitForWorkAround(2000);

            BulkUpdateHelper.MouseHover("Locator");

            BulkUpdateHelper.ClickElement("ClickOnQuickLinks");
            BulkUpdateHelper.WaitForWorkAround(1000);

            BulkUpdateHelper.ClickElement("ClickOnEditButton");
            BulkUpdateHelper.WaitForWorkAround(3000);

            BulkUpdateHelper.ClickElement("ClickOnSaveButton");

            BulkUpdateHelper.ClickElement("AccountsLink");
            BulkUpdateHelper.WaitForWorkAround(2000);

            BulkUpdateHelper.MouseHover("Locator");

            BulkUpdateHelper.ClickElement("ClickOnQuickLinks");
            BulkUpdateHelper.WaitForWorkAround(1000);

            BulkUpdateHelper.ClickElement("ClickOnDeleteButton");
            BulkUpdateHelper.WaitForWorkAround(3000);

            BulkUpdateHelper.AcceptAlert();
            BulkUpdateHelper.WaitForWorkAround(5000);

        }
    }
}