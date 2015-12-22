using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkDeleteLeads : DriverTestCase
    {
        [TestMethod]
        public void bulkdeleteleads()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewLeadHelper = new AddNewLeadHelper(GetWebDriver());
            var LeadBulkActionsHelper = new LeadBulkActionsHelper(GetWebDriver());
        
            
            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var LeadTitle = "Test Lead" + RandomNumber(1, 99);
            var LeadCompany = "Test Company" + RandomNumber(1, 99);

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            

            //Click on Leads
            AddNewLeadHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddNewLeadHelper.WaitForWorkAround(7000);


            //#################### CREATE A LEAD   #####################################

            //Create on Lead
            AddNewLeadHelper.ClickElement("ClickOnLeadAddNew");


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewLeadHelper.Select("SelectStatus", "New");

            //Select Source
            AddNewLeadHelper.Select("SelectSource", "Web Site");

            //Select Category
            AddNewLeadHelper.Select("SelectCategory", "9248");

            //Select Owner  
            AddNewLeadHelper.Select("SelectOwner", "1");

            //Select Manager
            AddNewLeadHelper.Select("SelectManager", "1");

            //Select Partner
            AddNewLeadHelper.Select("SelectPartner", "");


            //####################### LEAD DETAILS  #############################

            //Select Salutation
            AddNewLeadHelper.Select("SelectSalutation", "Mr");

            //Enter First Name
            AddNewLeadHelper.TypeText("EnterFirstName", FirstName);

            //Enter Middle Name
            AddNewLeadHelper.TypeText("EnterMiddleName", "");

            //Enter Last Name
            AddNewLeadHelper.TypeText("EnterLastName", LastName);

            //Enter Company Name
            AddNewLeadHelper.TypeText("EnterCompany", LeadCompany);

            //Enter Lead Title Name
            AddNewLeadHelper.TypeText("EnterLeadTitle", LeadTitle);

            //Enter Department Name
            AddNewLeadHelper.TypeText("EnterDepartment", "HR");

            //Enter Website
            AddNewLeadHelper.TypeText("EnterWebsite", "abc.com");

            //Enter No Of Employees
            AddNewLeadHelper.TypeText("EnterNoOfEmployees", "78");

            //Select Industry
            AddNewLeadHelper.Select("SelectIndustry", "Advertising");

            //Enter Annual Revenue
            AddNewLeadHelper.TypeText("EnterAnnualRevenue", "784512");



            //############################# LEAD ADDRESS   #################################


            //Select Address Type
            AddNewLeadHelper.Select("SelectAddressType", "Corporate");

            //Enter Address Line1
            AddNewLeadHelper.TypeText("EnterAddressLine1", "Test Addressline1");

            //Enter Address Line2
            AddNewLeadHelper.TypeText("EnterAddressLine2", "Test Addressline2");

            //Enter City
            AddNewLeadHelper.TypeText("EnterCity", "Test City");

            //Select State
            AddNewLeadHelper.Select("SelectState", "DC");

            //Select County
            AddNewLeadHelper.Select("SelectCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewLeadHelper.TypeText("EnterZipCode", "87452");


            //##################   CONTACT INFORMATION  #############################


            //Select Contact Salutation
            AddNewLeadHelper.Select("SelectContactSalutation", "Mr");

            //Enter Contact First Name
            AddNewLeadHelper.TypeText("EnterContactFirstName", FirstName);

            //Enter Contact Middle Name
            AddNewLeadHelper.TypeText("EnterContactMiddleName", "");

            //Enter Contact Last Name
            AddNewLeadHelper.TypeText("EnterContactLastName", LastName);

            //Select Contact Phone Type
            AddNewLeadHelper.Select("SelectContactPhoneType", "Cell");

            //Enter Contact Phone Number
            AddNewLeadHelper.TypeText("EnterContactPhoneNumber", "8745213698");

            //Select Contact Email Type
            AddNewLeadHelper.Select("SelectContactEmailType", "Work");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Email
            AddNewLeadHelper.TypeText("EnterContactEmail", "testemail@ymail.com");

            // Select Contact Social Link Type
            AddNewLeadHelper.Select("SelectContactSocialLinkType", "Facebook");

            //Enter Contact Social Link
            AddNewLeadHelper.TypeText("EnterContactSocialLink", "test@facebook.com");



            //###################### CONTACT INFORMATION ADDRESS  ######################################


            //Click on Add Address
            AddNewLeadHelper.ClickElement("ClickOnAddAddress");

            //Select Contact Address Type
            AddNewLeadHelper.Select("SelectContactAddressType", "Location");

            //Enter Contact Address Line1
            AddNewLeadHelper.TypeText("EnterContactAddressLine1", "Test Contact Addressline1");

            //Enter Contact Address Line2
            AddNewLeadHelper.TypeText("EnterContactAddressLine2", "Test Contact Addressline2");

            //Enter Contact City
            AddNewLeadHelper.TypeText("EnterContactCity", "Test Contact City");

            //Select Contact State
            AddNewLeadHelper.Select("SelectContactState", "GA");

            //Select Contact Country
            AddNewLeadHelper.Select("SelectContactCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Zip Code
            AddNewLeadHelper.TypeText("EnterContactZipCode", "25417");


            //######################  SAVE LEAD  ###########################

            //Click on Save
            AddNewLeadHelper.ClickElement("ClickOnSave");
            AddNewLeadHelper.WaitForWorkAround(10000);



//################### BULK DELETE LEADS  #########################

            
            //Click on Bulk Update
            LeadBulkActionsHelper.TypeText("SearchLeadCompany", LeadCompany);
            LeadBulkActionsHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            LeadBulkActionsHelper.ClickElement("ClickOnMasterCheckBox");
            
            //Click on Move over
            LeadBulkActionsHelper.MouseOver("Locator");
            

            //Click on Bulk Delete
            LeadBulkActionsHelper.ClickElement("ClickOnDeleteLeads");
            LeadBulkActionsHelper.WaitForWorkAround(4000);

            
            LeadBulkActionsHelper.AcceptAlert();
            LeadBulkActionsHelper.WaitForWorkAround(10000);


        }
    }
}