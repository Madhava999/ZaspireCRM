using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class TrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void trashindexpage()
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



            AddAccountHelper.TypeText("FilterSearchBox", "Live");
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.ClickElement("SelectOneRecord");

            AddAccountHelper.MouseHover("Locator");

            AddAccountHelper.ClickElement("ClickOnDeleteForever");
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);

           
            AddAccountHelper.TypeText("FilterSearchBox", "Declined");
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.ClickElement("SelectOneRecord");

            AddAccountHelper.MouseHover("Locator");

            AddAccountHelper.ClickElement("ClickOnRestoreAccounts");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(5000);

            //######################### Trash View Page ##########################

            AddAccountHelper.ClickElement("ClicOnTrashRecordViewPage");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");


   // ########################## Group Trash ##############

            AddAccountHelper.ClickElement("ClicOnGroupTrashButton");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");

            AddAccountHelper.Select("ClickOnPageNo.", "50");


        }
    }
}