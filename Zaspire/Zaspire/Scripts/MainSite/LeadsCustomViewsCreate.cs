using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsCustomViewsCreate : DriverTestCase
    {
        [TestMethod]
        public void leadscustomviewscreate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsCustomViewsCreateHelper = new LeadsCustomViewsCreateHelper(GetWebDriver());


            //Variable

            var LeadCustomView = "Lead Custom View" + RandomNumber(1, 99);



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnLeads");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsCustomViewsCreateHelper.WaitForWorkAround(7000);

            //Click on Leads Custom Views
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnCustomViews");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(10000);

            //Click on Add New
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnAddNew");


//################### CREATE A CUSTOM VIEW #########################


            //Enter Custom View Name
            LeadsCustomViewsCreateHelper.TypeText("EnterCustomViewName", LeadCustomView);

            //Select Sort By
            LeadsCustomViewsCreateHelper.Select("SelectSortBy", "Modified");


//################### ADD SEARCH CRITERIA FIELDS #########################
            
            //Select Owner
            LeadsCustomViewsCreateHelper.Select("SelectOwner", "Ranjith");

            //Select Manager
            LeadsCustomViewsCreateHelper.Select("SelectManager", "Ranjith");

            //Select Status
            LeadsCustomViewsCreateHelper.Select("SelectStatus", "New");

            //Select Source
            LeadsCustomViewsCreateHelper.Select("SelectSource", "Email");

            //Select Category
            LeadsCustomViewsCreateHelper.Select("SelectCategory", "Testing");

            //Select Created By
            LeadsCustomViewsCreateHelper.Select("SelectCreatedBy", "Ranjith");

            //Select Modified By
            LeadsCustomViewsCreateHelper.Select("SelectModifiedBy", "Ranjith");

            //Select Partner
            LeadsCustomViewsCreateHelper.Select("SelectPartner", "aspire");

            //Select Group
            LeadsCustomViewsCreateHelper.Select("SelectGroup", "16");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Created Date
            LeadsCustomViewsCreateHelper.Select("EnterCreated", "2015-11-16");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
            LeadsCustomViewsCreateHelper.Select("EnterModified", "2015-11-17");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);



//################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            LeadsCustomViewsCreateHelper.Select("SelectAdditionalField1", "d.city:string");

            //Select Operator
            LeadsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            LeadsCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Test");

            //Click On Add New Field
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            LeadsCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.industry:string");

            //Select Operator
            LeadsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            LeadsCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Dept");



            //Click on Leads
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnSave");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(10000);




        }
    }
}