using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void leadscustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsCustomViewsIndexHelper = new LeadsCustomViewsIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnLeads");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Leads Custom Views
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/custom_views");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Delete
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnDelete");

            //Click on Back
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnBack");

            //Click on Leads Custom Views
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Enter Filter Search Box
            LeadsCustomViewsIndexHelper.TypeText("EnterFilterSearchBox", "Lead Custom View");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnFilterReset");

            //Check Master Check Box
            LeadsCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            LeadsCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Click On Custom View
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/custom_views");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Edit
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/custom_views");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Delete
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewDelete");

            LeadsCustomViewsIndexHelper.AcceptAlert();
            LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Permission
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermission");

            //Click On Permission check
            LeadsCustomViewsIndexHelper.ClickElement("CheckBox1");

            //Click On Permission check
            LeadsCustomViewsIndexHelper.ClickElement("CheckBox2");

            //Click On Permission check
            LeadsCustomViewsIndexHelper.ClickElement("CheckBox3");

            //Click On Custom View Permission Save
            LeadsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermissionSave");
            LeadsCustomViewsIndexHelper.WaitForWorkAround(10000);



        }
    }
}