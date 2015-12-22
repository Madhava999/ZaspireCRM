using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadUpdate : DriverTestCase
    {
        [TestMethod]
        public void leadupdate()
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

            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var LeadCompany = "Test Company" + RandomNumber(1, 99);
            var LeadTitle = "Test Title" + RandomNumber(1, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";
            var Number = "12345678" + RandomNumber(10, 99);

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


//#################### UPDATE LEAD   #####################################

            //Open Lead
            AddNewLeadHelper.ClickElement("ClickOnLeadView");

            //Click On Edit link
            //AddNewLeadHelper.ClickElement("ClickOnEditLink");


//################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewLeadHelper.Select("SelectStatus", "Duplicate");

            //Select Source
            AddNewLeadHelper.Select("SelectSource", "Campaign");

            //Select Category
            AddNewLeadHelper.Select("SelectCategory", "9249");

            //Select Owner  
            AddNewLeadHelper.Select("SelectOwner", "58");

            //Select Manager
            AddNewLeadHelper.Select("SelectManager", "58");

            //Select Partner
            AddNewLeadHelper.Select("SelectPartner", "");


//####################### LEAD DETAILS  #############################

            //Select Salutation
            AddNewLeadHelper.Select("SelectSalutation", "Dr");

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
            AddNewLeadHelper.TypeText("EnterDepartment", "Marketing");

            //Enter Website
            AddNewLeadHelper.TypeText("EnterWebsite", "absc.com");

            //Enter No Of Employees
            AddNewLeadHelper.TypeText("EnterNoOfEmployees", "48");

            //Select Industry
            AddNewLeadHelper.Select("SelectIndustry", "Banking");

            //Enter Annual Revenue
            AddNewLeadHelper.TypeText("EnterAnnualRevenue", "789242");



//############################# LEAD ADDRESS   #################################


            //Select Address Type
            AddNewLeadHelper.Select("SelectAddressType", "Corporate");

            //Enter Address Line1
            AddNewLeadHelper.TypeText("EnterAddressLine1", "Test Addressline12");

            //Enter Address Line2
            AddNewLeadHelper.TypeText("EnterAddressLine2", "Test Addressline22");

            //Enter City
            AddNewLeadHelper.TypeText("EnterCity", "Test City1");

            //Select State
            AddNewLeadHelper.Select("SelectState", "CO");

            //Select County
            AddNewLeadHelper.Select("SelectCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewLeadHelper.TypeText("EnterZipCode", "87852");


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
            AddNewLeadHelper.Select("SelectContactPhoneType", "Home");

            //Enter Contact Phone Number
            AddNewLeadHelper.TypeText("EnterContactPhoneNumber", Number);

            //Select Contact Email Type
            AddNewLeadHelper.Select("SelectContactEmailType", "Home");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Email
            AddNewLeadHelper.TypeText("EnterContactEmail", Email);

            // Select Contact Social Link Type
            AddNewLeadHelper.Select("SelectContactSocialLinkType", "LinkedIn");

            //Enter Contact Social Link
            AddNewLeadHelper.TypeText("EnterContactSocialLink", "test987@linkedin.com");



//###################### CONTACT INFORMATION ADDRESS  ######################################


            //Click on Add Address
            //AddNewLeadHelper.ClickElement("ClickOnEditAddAddress");

            //Select Contact Address Type
            AddNewLeadHelper.Select("SelectEditContactAddressType", "Mailing");

            //Enter Contact Address Line1
            AddNewLeadHelper.TypeText("EnterEditContactAddressLine1", "Test Contact Addressline11");

            //Enter Contact Address Line2
            AddNewLeadHelper.TypeText("EnterEditContactAddressLine2", "Test Contact Addressline21");

            //Enter Contact City
            AddNewLeadHelper.TypeText("EnterEditContactCity", "Test Contact City1");

            //Select Contact State
            AddNewLeadHelper.Select("SelectEditContactState", "CT");

            //Select Contact Country
            AddNewLeadHelper.Select("SelectEditContactCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Zip Code
            AddNewLeadHelper.TypeText("EnterEditContactZipCode", "22367");


//######################  SAVE LEAD  ###########################

            //Click on Save
            AddNewLeadHelper.ClickElement("ClickOnEditLeadSave");
            AddNewLeadHelper.WaitForWorkAround(10000);

            //AddNewLeadHelper.VerifyPageText("Lead saved successfully.");
            //AddNewLeadHelper.WaitForWorkAround(10000);


        }
    }
}
