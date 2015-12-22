using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{

        [TestClass]
        public class FilterByTags : DriverTestCase
        {
            [TestMethod]
            public void filterbytags()
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

                //Click On Account Tab
                AddAccountHelper.ClickElement("ClickAccountsTab");


                AddAccountHelper.TypeText("FilterByTag", "New");
                

                AddAccountHelper.ClickElement("Search");
                AddAccountHelper.WaitForWorkAround(10000);

                AddAccountHelper.ClickElement("AccountsLink");
                AddAccountHelper.WaitForWorkAround(2000);



            
        }
    }
}