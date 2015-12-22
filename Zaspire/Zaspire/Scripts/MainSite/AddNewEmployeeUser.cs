using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewEmployeeUser : DriverTestCase
    {
        [TestMethod]
        public void addnewemployeeuser()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewEmployeeHelper = new AddNewEmployeeHelper(GetWebDriver());

            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



//#################### CREATE A EMPLOYEE   #####################################


            //Click on Employees
            AddNewEmployeeHelper.ClickElement("ClickOnEmployees");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            //AddNewLeadHelper.WaitForWorkAround(7000);

            //Create on Employee
            //AddNewEmployeeHelper.ClickElement("ClickOnEmployeeAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees/addnew");



//#################### EMPLOYEE DETAILS  #####################################


            //Select Salutation
            AddNewEmployeeHelper.Select("SelectSalutation", "Mr");

            //Enter First Name
            AddNewEmployeeHelper.TypeText("EnterFirstName", FirstName);

            //Enter Middle Name
            AddNewEmployeeHelper.TypeText("EnterMiddleName", "");

            //Enter Last Name
            AddNewEmployeeHelper.TypeText("EnterLastName", LastName);

            //Select Employee Type
            AddNewEmployeeHelper.Select("SelectEmployeeType", "Full Time");

            //Enter Contact Email
            AddNewEmployeeHelper.TypeText("EnterContactEmail", "Email");

            //Select Phone Type
            AddNewEmployeeHelper.Select("SelectPhoneType", "Home");

            //Enter Phone Number
            AddNewEmployeeHelper.TypeText("EnterPhoneNumber", "7845956321");



//############################# EMPLOYEE ADDRESS   #################################


            //Select Address Type
            AddNewEmployeeHelper.Select("SelectAddressType", "Location");

            //Enter Address Line1
            AddNewEmployeeHelper.TypeText("EnterAddressLine1", "Test Addressline1");

            //Enter Address Line2
            AddNewEmployeeHelper.TypeText("EnterAddressLine2", "Test Addressline2");

            //Enter City
            AddNewEmployeeHelper.TypeText("EnterCity", "Test City");

            //Select State
            AddNewEmployeeHelper.Select("SelectState", "DC");

            //Select County
            AddNewEmployeeHelper.Select("SelectCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewEmployeeHelper.TypeText("EnterZipCode", "82452");


//##################   DEPARTMENT, ROLE & TEAM  #############################


            //Select Department
            //AddNewEmployeeHelper.Select("SelectDepartment", "");

            //Select Role
            //AddNewEmployeeHelper.Select("SelectRole", "");

            //Select Team
            //AddNewEmployeeHelper.Select("SelectTeam", "");



//######################  USER DETAILS  ###########################


            //Click On Check Box
            AddNewEmployeeHelper.ClickElement("ClickOnCheckBox");

            //Enter Login Email
            AddNewEmployeeHelper.TypeText("EnterLoginEmail", Email);

            //Enter Password
            AddNewEmployeeHelper.TypeText("EnterPassword", "aspireCRM");

            //Click On Donot Email Check Box
            AddNewEmployeeHelper.ClickElement("ClickOnDonotEmail");

            //Click On Admin User Check Box
            AddNewEmployeeHelper.ClickElement("ClickOnAdminUser");




//######################  SAVE EMPLOYEE  ###########################

            //Click on Save
            AddNewEmployeeHelper.ClickElement("ClickOnSave");
            AddNewEmployeeHelper.WaitForWorkAround(10000);




        }
    }
}
