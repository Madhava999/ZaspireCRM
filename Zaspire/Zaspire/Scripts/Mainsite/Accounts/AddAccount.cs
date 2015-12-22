using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class AddAccount : DriverTestCase
    {
        [TestMethod]
        public void addaccount()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addaccountHelper = new AddAccountHelper(GetWebDriver());
           // var addContactHelper = new AddContactHelper(GetWebDriver());

            //Variable
            var mail = "Test" + RandomNumber(1, 99) + "@yopmail.com";
            //var numb = "0123456789" + RandomNumber(0, 9);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            addaccountHelper.WaitForWorkAround(10000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Clients in Topmenu
            addaccountHelper.ClickElement("ClickAccountsTab");
            //addaccountHelper.WaitForWorkAround(2000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/oculus/accounts");
            //addaccountHelper.WaitForWorkAround(7000);


            //################################# CREATE A CONTACT   #############################################

            //Click On Create
            //addaccountHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/addnew");
            addaccountHelper.WaitForWorkAround(5000);


            //Select Status
            addaccountHelper.Select("SelectStatus", "New");

            //Select Source
            addaccountHelper.Select("SelectSource", "Email");
            addaccountHelper.WaitForWorkAround(2000);

            //Select Category
            addaccountHelper.Select("SelectCategory", "12405");
            addaccountHelper.WaitForWorkAround(2000);

            //Select Owner
            addaccountHelper.Select("SelectOwner", "17");

            //Select Manager
            addaccountHelper.Select("SelectManager", "17");

            //Select Partner
            addaccountHelper.Select("SelectPartner", "2");


         //##############################Account Details

              //Enter Company Name  
            addaccountHelper.TypeText("CompanyName", "TesT Company");

              //Enter Company Name  
            addaccountHelper.TypeText("LegalName", "TesT Company");

              //Enter Company Name  
            addaccountHelper.TypeText("Website", "www.testcompany.com");

              //Enter Company Name  
            addaccountHelper.Select("Industry", "Accounting");

              //Enter Company Name  
            addaccountHelper.TypeText("No.ofEmployees", "4500");

              //Enter Company Name  
            addaccountHelper.TypeText("TickerSymbol", "TesT Company");

          //#############################Contact Information

            // Select Salutation
            addaccountHelper.Select("Salutation", "Mr");


            //Enter First Name
            addaccountHelper.TypeText("FirstNAME", "John");

            //Enter Middle Name
            addaccountHelper.TypeText("MiddleName", "K");


            //Enter Last Name
            addaccountHelper.TypeText("LastName", "peter");

          
        
            //######################## PHONE    #########################


            //SelectPhoneType
            addaccountHelper.Select("PhoneType", "Cell");

            //SelectCountryCode
            //addContactHelper.Select("CountryCode", "Canada/UnitedStates");

            //Enter First Name
            addaccountHelper.TypeText("PhoneNumber", "(789) 541-2549");

            //Click on DoNotCall
            addaccountHelper.ClickElement("DoNotCall");

            //####################### EMAIL AND INTERNET    ##########################################

            //Select Email Type
            addaccountHelper.Select("SelectEmailType", "Work");

            //Enter Eaddrress
            addaccountHelper.TypeText("Eaddrress", mail);

           //$$$$$$$$$$$$$$$$$$$$$$$$$ Social Links

            /*//Select Social Link Type
            addaccountHelper.Select("SocialLinkType","Facebook");

            //Select Social Link id
            addaccountHelper.TypeText("Socialid", mail);*/



            //############################# ADDRESS   ##################################3

            //Select Address Type
            addaccountHelper.Select("AddressType", "Corporate");

            //Enter Address Line1
            addaccountHelper.TypeText("AddressLine1", "301 ibmbldng");

            //Enter Address Line2
           addaccountHelper.TypeText("AddressLine2", "James Street");

            //Enter City
            addaccountHelper.TypeText("City", "Ohio");

            //Select Country
            addaccountHelper.Select("SelectCountry", "USA");
            addaccountHelper.WaitForWorkAround(3000);

            //Select Address Type
            addaccountHelper.Select("AddressState", "AK");

            //Select Zip Code
            addaccountHelper.TypeText("ZipCode", "14589");
            addaccountHelper.WaitForWorkAround(2000);


            //cLICK DoNotSolicit
            //addaccountHelper.ClickElement("DoNotSolicit");

            //CLICK DoNotSolicit
            //addaccountHelper.ClickElement("AddRemark");

            //CLICK DoNotSolicit
            //addaccountHelper.TypeText("RemarkText", "this is test remark");


            //#######################    CLICK ON ADD DUBLICATE    ########################


            //CLICK DoNotSolicit
            addaccountHelper.ClickElement("SaveAccountbtn");
            addaccountHelper.WaitForWorkAround(2000);
            
            //Click On Save Or Dublicate
            //addaccountHelper.ClickOnSaveOrDublicate();


            //Verify Confirmation Text
            //addaccountHelper.VerifyPageText("Account has been created");
            //addaccountHelper.WaitForWorkAround(5000);

        }
    }
}
