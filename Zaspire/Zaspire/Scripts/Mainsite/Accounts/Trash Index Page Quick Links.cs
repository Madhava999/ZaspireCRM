using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class Trash_Index_Page_Quick_Links : DriverTestCase
    {
        [TestMethod]
        public void trashindexpagequicklinks()
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


            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);



            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);


            AddAccountHelper.MouseHover1("locator");

            AddAccountHelper.ClickElement("ClickOnQuickLinks");

            AddAccountHelper.ClickElement("ClickonDeleteForeverButton");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(7000);

            AddAccountHelper.MouseHover1("locator");

            AddAccountHelper.ClickElement("ClickOnQuickLinks");

            AddAccountHelper.ClickElement("ClickonRestoreButton");
            AddAccountHelper.WaitForWorkAround(10000);
        }
    }
}
