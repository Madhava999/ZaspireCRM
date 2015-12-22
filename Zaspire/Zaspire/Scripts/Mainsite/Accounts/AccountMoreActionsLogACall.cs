using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
 public class AccountMoreActionsLogACall : DriverTestCase
        {
            [TestMethod]
            public void accountmoreactionslogacall()
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
                AccountsMoreActionsHelper AccountMoreActionsLogACallHelper= new AccountsMoreActionsHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                AccountMoreActionsLogACallHelper.WaitForWorkAround(4000);

                //Click On Client Tab
                AccountMoreActionsLogACallHelper.ClickElement("ClickonAccountsTab");
                AccountMoreActionsLogACallHelper.WaitForWorkAround(4000);


                //Click to open client info
                AccountMoreActionsLogACallHelper.Click("SelectRecord");

                //Click on Add Note button
                AccountMoreActionsLogACallHelper.ClickLogACall();

                //Select displayed new window
                //AccountMoreActionsLogACall.SelectWindow("");

                //Enter note subject
                AccountMoreActionsLogACallHelper.TypeText("CallSubject", "LogACall-1");

                AccountMoreActionsLogACallHelper.Select("CallType","Outbound");

                AccountMoreActionsLogACallHelper.TypeText("CallDate", "2015-10-29");

                AccountMoreActionsLogACallHelper.Select("CallFrom", "RicharKent");

                AccountMoreActionsLogACallHelper.Select("CallTo", "PaulAnderson");

                AccountMoreActionsLogACallHelper.TypeText("EnterNumberFrom", "(789) 541-2549");

                AccountMoreActionsLogACallHelper.TypeText("EnterNumberTo", "(789) 541-2549");

                AccountMoreActionsLogACallHelper.Click("CallStartTime");

               //Enter note description
                AccountMoreActionsLogACallHelper.EnterDesc("This is demo file description");

                AccountMoreActionsLogACallHelper.TypeText("TimeinHrs", "02");

                AccountMoreActionsLogACallHelper.TypeText("TimeinMins", "20");

                AccountMoreActionsLogACallHelper.TypeText("TimeinSecs", "30");

                //Click on Save button
                AccountMoreActionsLogACallHelper.ClickButtonText("Save");

                //Logout from the application
                GetWebDriver().Navigate().GoToUrl(LogoutUrl);


            }
        }
    }
