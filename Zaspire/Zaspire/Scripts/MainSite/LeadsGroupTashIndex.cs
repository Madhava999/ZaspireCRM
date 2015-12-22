using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsGroupTashIndex : DriverTestCase
    {
        [TestMethod]
        public void leadsgrouptrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsGroupTrashIndexHelper = new LeadsGroupTrashIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnLeads");
            LeadsGroupTrashIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsGroupTrashIndexHelper.WaitForWorkAround(7000);


            //Click on Trash
            //LeadsGroupTrashIndexHelper.ClickElement("ClickOnTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");
            LeadsGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click on Group Trash
            //LeadsGroupTrashIndexHelper.ClickElement("ClickOnGroupTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups/trash");
            LeadsGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Back Button
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnBack");

            //Click On Back To LeadsTrash
            //LeadsGroupTrashIndexHelper.ClickElement("ClickOnBackToLeadsGroupTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups/trash");

            //Click On Group Trash Button
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnGroupTrash");

            //Click On Back To LeadsTrash
            //LeadsGroupTrashIndexHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");

            //Click On Lead View
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnLeadView");

            //Click On Back To LeadsTrash
            //LeadsGroupTrashIndexHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");

            //Enter Filter Search
            LeadsGroupTrashIndexHelper.TypeText("EnterFilterSearch", "Test");
            LeadsGroupTrashIndexHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            LeadsGroupTrashIndexHelper.MouseHover("locator");

            //Click On Delete Forever
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnDeleteForever");

            LeadsGroupTrashIndexHelper.AcceptAlert();
            LeadsGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            LeadsGroupTrashIndexHelper.MouseHover("locator");

            //Click On Restore Leads
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnRestoreLeads");

            LeadsGroupTrashIndexHelper.AcceptAlert();
            LeadsGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            LeadsGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnDelete");

            LeadsGroupTrashIndexHelper.AcceptAlert();
            LeadsGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            LeadsGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            LeadsGroupTrashIndexHelper.ClickElement("ClickOnRestore");

            LeadsGroupTrashIndexHelper.AcceptAlert();
            LeadsGroupTrashIndexHelper.WaitForWorkAround(10000);

            
            
        }
    }
}
