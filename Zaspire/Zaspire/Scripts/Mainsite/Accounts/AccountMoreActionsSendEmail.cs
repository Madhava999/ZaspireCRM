using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{

    [TestClass]
    public class AccountMoreActionsSendEmail : DriverTestCase
    {
        [TestMethod]
        public void accountmoreactionssendEmail()
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
            AccountsMoreActionsHelper.Click("SelectRecord");

            //Click to open client info
            AccountsMoreActionsHelper.OpenAccount();

            //Click on Add Note button
            AccountsMoreActionsHelper.MouseOver("Locator");

            //Click on Send email link
            AccountsMoreActionsHelper.ClickButtonText("Send E-Mail");

            //Verify user redirect at Compose screen
            VerifyTitle("Compose");

            //Enter Email to Address
            AccountsMoreActionsHelper.TypeText("To Address","nyeddu@charterglobal.com");

            //Click on Source icon to enable the desc textarea
            //clientHelper.ClickSourceIcon();

            //Enter email body text
            AccountsMoreActionsHelper.TypeText("EmailSubject","Sample Email");

            //Click on Source icon to enable the desc textarea
            //clientHelper.ClickSourceIcon();


            AccountsMoreActionsHelper.TypeText("Enter Description", "Regarding Email");

            //Click on Send email button
            AccountsMoreActionsHelper.ClickSend();

            //Verify user reditect back to details screen
            VerifyTitle("Details");
            AccountsMoreActionsHelper.WaitForWorkAround(5000);

            //Verify Sent email details available under Client history
            AccountsMoreActionsHelper.VerifyPageText("E-Mail Sent Successfully.");
            AccountsMoreActionsHelper.WaitForWorkAround(5000);

            //Logout from the application
            GetWebDriver().Navigate().GoToUrl(LogoutUrl);
        }
    }
}
