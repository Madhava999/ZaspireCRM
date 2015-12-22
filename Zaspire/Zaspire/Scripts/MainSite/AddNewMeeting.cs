using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewMeeting : DriverTestCase
    {
        [TestMethod]
        public void addnewmeeting()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewEventHelper = new AddNewEventHelper(GetWebDriver());

            //Variable

            var EventSubject = "Test Meeting" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Events
            AddNewEventHelper.ClickElement("ClickOnEvents");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events");
            //AddNewEventHelper.WaitForWorkAround(7000);


            //#################### CREATE A MEETING   #####################################

            //Create on Task
            //AddNewEventHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events/addnew");



            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Related To
            AddNewEventHelper.Select("SelectRelatedTo", "11");

            //Click On Merge Button
            AddNewEventHelper.ClickElement("ClickOnMergeButton");

            //Select Related To Record
            AddNewEventHelper.ClickElement("SelectRelatedRecord");


            //Select Event Category
            AddNewEventHelper.Select("EventEventCategory", "9242");

            //Select Event Priority
            AddNewEventHelper.Select("EventEventPriority", "High");

            //Select Owner  
            AddNewEventHelper.Select("SelectEventOwner", "1");

            //Select Event Type
            AddNewEventHelper.Select("SelectEventType", "Meeting");

            //Select Event Status
            AddNewEventHelper.Select("SelectEventStatus", "In Progress");

            //Enter Event Subject
            AddNewEventHelper.TypeText("EnterEventSubject", EventSubject);

            //Enter Event Location
            AddNewEventHelper.TypeText("EnterEventLocation", "Test City");

            //Enter Event Start Date
            AddNewEventHelper.TypeText("SelectEventStartDate", "2015-12-11");

            //Click On Start Time
            //AddNewEventHelper.ClickElement("SelectStartTime");

            //Click On Starting Time
            //AddNewEventHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddNewEventHelper.ClickElement("ClickOnMinutes");

            //Enter Event Due Date
            AddNewEventHelper.TypeText("SelectEventDueDate", "2015-12-12");

            //Click On End Time
            //AddNewEventHelper.ClickElement("SelectEndTime");

            //Click On Starting Time
            //AddNewEventHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddNewEventHelper.ClickElement("ClickOnMinutes");

            //Click On Check Reminder Check Box
            //AddNewEventHelper.ClickElement("CheckReminder");

            //Select Reminder Time
            //AddNewEventHelper.ClickElement("SelectReminderTime");

            //Click On Check Email Check Box
            //AddNewEventHelper.ClickElement("CheckEmail");

            //Select Email Reminder Time
            //AddNewEventHelper.ClickElement("SelectEmailReminderTime");






            //Click On Save
            AddNewEventHelper.ClickElement("ClickOnSave");
            AddNewEventHelper.WaitForWorkAround(7000);














        }
    }
}