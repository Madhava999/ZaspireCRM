using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;


namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class MoreActionsAppointment : DriverTestCase
        {
            [TestMethod]
            public void moreactionsappointment()
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
                

                //Click on Add Note button
                AccountsMoreActionsHelper.MouseOver("Locator");

                AccountsMoreActionsHelper.ClickElement("Appointment");

                AccountsMoreActionsHelper.TypeText("Location", "Ohio");

                AccountsMoreActionsHelper.TypeText("EnterSubject", "New Appointment");

                AccountsMoreActionsHelper.TypeText("StartDate", "2015-10-29");

                AccountsMoreActionsHelper.Click("StartTime");

                AccountsMoreActionsHelper.Select("EndDate", "2015-10-29");

                AccountsMoreActionsHelper.Click("EndTime");

                AccountsMoreActionsHelper.Click("Remaider");

                AccountsMoreActionsHelper.Click("RemainderTime");

                AccountsMoreActionsHelper.Click("EmailCheckbox");

                AccountsMoreActionsHelper.Click("EmailRemainder");

                AccountsMoreActionsHelper.Click("RecurringEvent");

                //AccountsMoreActionsHelper.Select("Repeatonceinayear","1");

                AccountsMoreActionsHelper.Click("Repeatonceinayeardays");

                //AccountsMoreActionsHelper.Click("Until");

                AccountsMoreActionsHelper.TypeText("Until", "2015-11-03");

                AccountsMoreActionsHelper.Select("invitees", "Employees");

                AccountsMoreActionsHelper.TypeText("Email", "nthamishetty@charterglobal.com");

                AccountsMoreActionsHelper.TypeText("FirstName", "John");

                AccountsMoreActionsHelper.TypeText("LastName", "Nash");

                AccountsMoreActionsHelper.Click("Search");

                AccountsMoreActionsHelper.Click("EnterDescLink");

                AccountsMoreActionsHelper.EnterDesc("This is Sample data information");

              
                //Click on Save button
                AccountsMoreActionsHelper.ClickButtonText("Save");

                //Logout from the application
                GetWebDriver().Navigate().GoToUrl(LogoutUrl);


            }
        }
    }
