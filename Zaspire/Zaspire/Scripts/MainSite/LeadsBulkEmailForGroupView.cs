﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsBulkEmailForGroupView : DriverTestCase
    {
        [TestMethod]
        public void leadsbulkemailforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsBulkActionsForGroupViewHelper = new LeadsBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            LeadsBulkActionsForGroupViewHelper.ClickElement("FirstLeadGroupNameLink");


//################### BULK UPDATE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            LeadsBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            LeadsBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Bulk Email
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnBulkEmail");
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            LeadsBulkActionsForGroupViewHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            LeadsBulkActionsForGroupViewHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            LeadsBulkActionsForGroupViewHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            LeadsBulkActionsForGroupViewHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            LeadsBulkActionsForGroupViewHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            LeadsBulkActionsForGroupViewHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            LeadsBulkActionsForGroupViewHelper.ClickElement("ClickOnSendButton");
            LeadsBulkActionsForGroupViewHelper.WaitForWorkAround(10000);







        }
    }
}