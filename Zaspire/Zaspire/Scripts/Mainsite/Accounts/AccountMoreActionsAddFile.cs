using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
   [TestClass]
    public class AccountMoreActionsAddFile : DriverTestCase
        {
            [TestMethod]
            public void accountmoreactionsaddfile()
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
                AccountsMoreActionsHelper AccountMoreActionsAddFileHelper = new AccountsMoreActionsHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                AccountMoreActionsAddFileHelper.WaitForWorkAround(4000);

                //Click On Client Tab
                AccountMoreActionsAddFileHelper.ClickElement("ClickonAccountsTab");
                AccountMoreActionsAddFileHelper.WaitForWorkAround(4000);


                //Click to open client info
                AccountMoreActionsAddFileHelper.OpenAccount();

                //Click on Add Note button
                AccountMoreActionsAddFileHelper.ClickAddFile();

                //Select displayed new window
                AccountMoreActionsAddFileHelper.TypeText("FileName","File1");

                //Enter note subject
                AccountMoreActionsAddFileHelper.TypeText("Description","This is demo File subject");

                AccountMoreActionsAddFileHelper.Select("FileCategory", ".txt");

                AccountMoreActionsAddFileHelper.Click("FileLogo");

                //Enter note description
                //AccountMoreActionsAddFileHelper.EnterDesc("This is demo file description");



                //Click on Save button
                AccountMoreActionsAddFileHelper.ClickButtonText("Save");

                //Select the main window
                //AccountMoreActionsAddFileHelper.SelectWindowWithTitle("Details");

                //Verify Page title
               // VerifyTitle("Details");

                //Verify newly added note available at details screen.
                //AccountMoreActionsAddFileHelper.VerifyPageText("This is demo file subject");

                //Logout from the application
                //GetWebDriver().Navigate().GoToUrl(LogoutUrl);


            }
        }
    }
