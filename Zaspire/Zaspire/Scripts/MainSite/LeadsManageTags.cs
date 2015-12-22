using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsManageTags : DriverTestCase
    {
        [TestMethod]
        public void leadsmanagetags()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsViewPageHelper = new LeadsViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            LeadsViewPageHelper.ClickElement("FirstLeadNameLink");


//################### MANAGE TAGS  #########################


            //Click on Manage Tags
            LeadsViewPageHelper.ClickElement("ClickOnManageTags");


//################### YOUR TAGS  #########################


            //Enter Your Tag Name
            LeadsViewPageHelper.TypeText("EnterYourTagName", "Testtag");

            //Click on Save
            LeadsViewPageHelper.ClickElement("ClickOnYourTagSave");
            LeadsViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS SYSTEM GENERATED TAGS #########################


            //Click on Manage Tags
            LeadsViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            LeadsViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Edit
            LeadsViewPageHelper.ClickElement("ClickOnTagsEdit");

            //Uncheck State
            LeadsViewPageHelper.ClickElement("UncheckState");

            //Uncheck Department
            LeadsViewPageHelper.ClickElement("UncheckDepartment");

            //Click On Recreate button
            LeadsViewPageHelper.ClickElement("ClickOnRecreate");
            LeadsViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS DELETE  #########################


            //Click on Manage Tags
            LeadsViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            LeadsViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Delete
            LeadsViewPageHelper.ClickElement("ClickOnTagsDelete");
            LeadsViewPageHelper.WaitForWorkAround(10000);


//################### TAGS SEARCH  #########################


            //Click on Tag Name
            LeadsViewPageHelper.ClickElement("ClickOnTagsName");
            LeadsViewPageHelper.WaitForWorkAround(10000);




        }
    }
}