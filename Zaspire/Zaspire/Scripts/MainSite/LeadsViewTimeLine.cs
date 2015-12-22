using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsViewTimeLine : DriverTestCase
    {
        [TestMethod]
        public void leadsviewtimeline()
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


//################### INLINE EDIT CHANGE STATUS #########################


            //Click on Change Status
            LeadsViewPageHelper.ClickElement("ChangeStatus");


//################### INLINE EDIT CHANGE OWNER  #########################


            //Click on Owner
            LeadsViewPageHelper.ClickElement("ClickOnOwner");

            //Select Owner
            LeadsViewPageHelper.Select("SelectOwner", "57");

            //Click On Ok button
            LeadsViewPageHelper.ClickElement("ClickOnOwnerOk");


//################### INLINE EDIT CHANGE MANAGER  #########################


            //Click on Manager
            LeadsViewPageHelper.ClickElement("ClickOnManager");

            //Select Manager
            LeadsViewPageHelper.Select("SelectManager", "57");

            //Click On Ok button
            LeadsViewPageHelper.ClickElement("ClickOnManagerOk");

//################### TIME LINE  #########################


            //Click On More Activity
            LeadsViewPageHelper.ClickElement("ClickOnMoreActivity");
                        
            //Click On List View
            LeadsViewPageHelper.ClickElement("ClickOnListView");

            //Enter List View Search Box
            LeadsViewPageHelper.TypeText("EnterListViewSearchBox", "");
            LeadsViewPageHelper.WaitForWorkAround(8000);

            //Click On Reset Button
            LeadsViewPageHelper.ClickElement("ClickOnListViewReset");

            //Click On Graphical View
            LeadsViewPageHelper.ClickElement("ClickOnGraphicalView");
            LeadsViewPageHelper.WaitForWorkAround(10000);

            //Click On User Name
            LeadsViewPageHelper.ClickElement("ClickOnUserName");
            

        }
    }
}