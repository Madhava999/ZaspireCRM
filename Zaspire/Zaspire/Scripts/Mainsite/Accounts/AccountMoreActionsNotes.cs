using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;


namespace Zaspire.Scripts.Mainsite
{
   [TestClass]
        public class AccountMoreActionsNotes : DriverTestCase
        {
            [TestMethod]
            public void accountmoreactionsnotes()
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
                AccountsMoreActionsHelper AccountsMoreActionsNotesHelper = new AccountsMoreActionsHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                AccountsMoreActionsNotesHelper.WaitForWorkAround(4000);

                //Click On Client Tab
                AccountsMoreActionsNotesHelper.ClickElement("ClickonAccountsTab");
                AccountsMoreActionsNotesHelper.WaitForWorkAround(4000);


                //Click to open client info
                AccountsMoreActionsNotesHelper.OpenAccount();

                //Click on Add Note button
                AccountsMoreActionsNotesHelper.ClickAddNote();

                //Select displayed new window
                AccountsMoreActionsNotesHelper.SelectWindow("");

                //Enter note subject
                AccountsMoreActionsNotesHelper.EnterNoteSubject("This is demo note subject");

                //Enter note description
                AccountsMoreActionsNotesHelper.EnterDesc( "demo note description");

                //Click on Save button
                AccountsMoreActionsNotesHelper.ClickButtonText("Save");

                //Select the main window
                AccountsMoreActionsNotesHelper.SelectWindowWithTitle("Details");

                //Verify Page title
                VerifyTitle("Details");

                //Verify newly added note available at details screen.
                AccountsMoreActionsNotesHelper.VerifyPageText("This is demo note subject");

                //Logout from the application
                GetWebDriver().Navigate().GoToUrl(LogoutUrl);


            }
        }
    }
