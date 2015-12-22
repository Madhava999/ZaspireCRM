using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void leadstrashindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsTrashIndexPageHelper = new LeadsTrashIndexPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsTrashIndexPageHelper.ClickElement("ClickOnLeads");
            LeadsTrashIndexPageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsTrashIndexPageHelper.WaitForWorkAround(7000);


            //Click on Trash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");
            LeadsTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Back Button
            LeadsTrashIndexPageHelper.ClickElement("ClickOnBack");

            //Click On Back To LeadsTrash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");

            //Click On Group Trash Button
            LeadsTrashIndexPageHelper.ClickElement("ClickOnGroupTrash");

            //Click On Back To LeadsTrash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");

            //Click On Lead View
            LeadsTrashIndexPageHelper.ClickElement("ClickOnLeadView");

            //Click On Back To LeadsTrash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");

            //Enter Filter Search
            LeadsTrashIndexPageHelper.TypeText("EnterFilterSearch", "Test");
            LeadsTrashIndexPageHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            LeadsTrashIndexPageHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            LeadsTrashIndexPageHelper.MouseHover("locator");

            //Click On Delete Forever
            LeadsTrashIndexPageHelper.ClickElement("ClickOnDeleteForever");

            LeadsTrashIndexPageHelper.AcceptAlert();
            LeadsTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            LeadsTrashIndexPageHelper.MouseHover("locator");

            //Click On Restore Leads
            LeadsTrashIndexPageHelper.ClickElement("ClickOnRestoreLeads");

            LeadsTrashIndexPageHelper.AcceptAlert();
            LeadsTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            LeadsTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            LeadsTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            LeadsTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            LeadsTrashIndexPageHelper.ClickElement("ClickOnDelete");

            LeadsTrashIndexPageHelper.AcceptAlert();
            LeadsTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            LeadsTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            LeadsTrashIndexPageHelper.ClickElement("ClickOnRestore");

            LeadsTrashIndexPageHelper.AcceptAlert();
            LeadsTrashIndexPageHelper.WaitForWorkAround(10000);

            
            
        }
    }
}
