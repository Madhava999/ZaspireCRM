using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

{
   [TestClass]
    public class UpdatePage : DriverTestCase
        {
            [TestMethod]
            public void updatepage()
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

                AddAccountHelper.ClickElement("SelectClient1");

           

                AddAccountHelper.ClickElement("MouseOver");

                AddAccountHelper.MouseOver("Locator");

                AddAccountHelper.ClickElement("Edit");
                AddAccountHelper.WaitForWorkAround(4000);

                AddAccountHelper.ClickButtonText("ClickAccountsTab");

               


            }
        }
    }
