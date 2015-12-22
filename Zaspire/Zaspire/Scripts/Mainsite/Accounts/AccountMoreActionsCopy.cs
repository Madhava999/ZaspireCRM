using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
  
   [TestClass]
        public class AccountMoreActionsCopy : DriverTestCase
        {
            [TestMethod]
            public void accountsmoreactionscopy()
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
                AccountsMoreActionsHelper AccountsMoreActionsHelper = new AccountsMoreActionsHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                AccountsMoreActionsHelper.WaitForWorkAround(4000);

                //Click On Client Tab
                AccountsMoreActionsHelper.ClickElement("ClickonAccountsTab");
                AccountsMoreActionsHelper.WaitForWorkAround(4000);


                //Click to open client info
                AccountsMoreActionsHelper.OpenAccount();
                AccountsMoreActionsHelper.WaitForWorkAround(3000);


                //Click on Add Note button
                AccountsMoreActionsHelper.MouseOver("Locator");

                //Select displayed new window
                AccountsMoreActionsHelper.ClickElement("Copy");


                AccountsMoreActionsHelper.AcceptAlert();
                AccountsMoreActionsHelper.WaitForWorkAround(2000);

               


            }
        }
    }
