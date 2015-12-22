using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddAppointmentForLead : DriverTestCase
    {
        [TestMethod]
        public void addappointmentforlead()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForLeadHelper = new AddEventsForLeadHelper(GetWebDriver());

            //Variable

            var AppointmentSubject = "Test Appointment" + RandomNumber(1, 99);
            var AppointmentLocation = "Test City" + RandomNumber(1, 99);
           

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForLeadHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForLeadHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForLeadHelper.ClickElement("MoveHover");
            AddEventsForLeadHelper.WaitForWorkAround(10000);


//################### CLASSIFICATIONS & OWNERSHIP  #########################


            //Click on Add Appointment
            AddEventsForLeadHelper.ClickElement("ClickOnAddAppointment");

            //Select Event Type
            AddEventsForLeadHelper.Select("SelectEventType", "Appointment");

            //Enter Event Location
            AddEventsForLeadHelper.TypeText("EnterEventLocation", AppointmentLocation);

            //Enter Event Subject
            AddEventsForLeadHelper.TypeText("EnterEventSubject", AppointmentSubject);
            

            //Enter Event Start Date
            AddEventsForLeadHelper.TypeText("SelectEventStartDate", "2015-12-09");

            //Click On Start Time
            //AddEventsForLeadHelper.ClickElement("SelectStartTime");

            //Click On Starting Time
            //AddEventsForLeadHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForLeadHelper.ClickElement("ClickOnMinutes");

            //Enter Event Due Date
            AddEventsForLeadHelper.TypeText("SelectEventDueDate", "2015-12-09");

            //Click On End Time
            //AddEventsForLeadHelper.ClickElement("SelectEndTime");

            //Click On Starting Time
            //AddEventsForLeadHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForLeadHelper.ClickElement("ClickOnMinutes");

            //Click On Check Reminder Check Box
            //AddEventsForLeadHelper.ClickElement("CheckReminder");

            //Select Reminder Time
            //AddEventsForLeadHelper.ClickElement("SelectReminderTime");

            //Click On Check Email Check Box
            //AddEventsForLeadHelper.ClickElement("CheckEmail");

            //Select Email Reminder Time
            //AddEventsForLeadHelper.ClickElement("CheckRecurringEvent");






            //Click On Save
            AddEventsForLeadHelper.ClickElement("ClickOnSave");
            AddEventsForLeadHelper.WaitForWorkAround(7000);


        }
    }
}